using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motochek_Processor
{
    public partial class Form1 : Form
    {
        private Boolean file1OK = false;
        private Boolean file2OK = false;
        private Boolean fuelFileOK = false;
        private Boolean vinFileOK = false;  

        private String[] rawPermitData;
        private String[] rawRUCData;
        private String[] rawFuelData;
        private String[] rawVINData;

        private List<String> vinNumbers;
        private List<String> userNames;
        private List<String> regos;

        private String rego;
        private String vin;
        private String regExp;
        private String wofExp;
        private String cofExp;
        private String rucExp;
        private String fuelType;
        private String make;
        private String model;
        private String vehicleYear;
        private String client;

        private List<String> outputs;
        private List<String> fuelOutput;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetVars();
            outputs = new List<String>();
            fuelOutput = new List<String>();
            vinNumbers = new List<string>();
            userNames = new List<string>();
            //create headings for CSV
            outputs.Add("rego,vin,regExp,wofExp,cofExp,rucExp,client");
            fuelOutput.Add("rego, vin, vehicleYear, make, model, fuelType");
        }
        
        //button clicks for reminder import features

        private void Button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                permitTextBox.Text = openFileDialog1.FileName;
                file1OK = true;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                rucTextBox.Text = openFileDialog2.FileName;
                file2OK = true;
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            //check if both files have been selected and then process them.
            if (file1OK && file2OK && vinFileOK)
            {
                rawPermitData = File.ReadAllLines(permitTextBox.Text);
                rawRUCData = File.ReadAllLines(rucTextBox.Text);
                rawVINData = File.ReadAllLines(vinTextBox.Text);
                ProcessRawVINData();
                ProcessRegWOFFile();
            }
            else
            {
                MessageBox.Show("Please select correct files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //button clicks for fuel processing features

        private void btnSelectVehicleDetails_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                fuelTextBox.Text = openFileDialog3.FileName;
                fuelFileOK = true;
            }
        }

        private void btnFuelProcess_Click(object sender, EventArgs e)
        {
            if(fuelFileOK)
            {
                rawFuelData = File.ReadAllLines(fuelTextBox.Text);
                ProcessFuelFile();

            }
            else
            {
                MessageBox.Show("Please select vehicle details file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //processing functions for reminders

        private void ProcessRegWOFFile()
        {
            for(int i = 0; i < rawPermitData.Length; i++)
            {
                if (i == 0)
                {
                    //ignore first line of the text file.
                    continue;
                }
                else
                {
                    rego = rawPermitData[i].Substring(1, 6).Replace(" ", string.Empty);
                    vin = rawPermitData[i].Substring(13, 17).Replace(" ", string.Empty);
                    regExp = rawPermitData[i].Substring(627, 2) + "-" + rawPermitData[i].Substring(629, 2) + "-" + rawPermitData[i].Substring(631, 4);
                    
                    //check if vehicle has COF instead of WOF.
                    if(rawPermitData[i].Substring(687, 1) == "Y")
                    {
                        cofExp = rawPermitData[i].Substring(697, 2) + "-" + rawPermitData[i].Substring(699, 2) + "-" + rawPermitData[i].Substring(701, 4);
                    }
                    else
                    {
                        wofExp = rawPermitData[i].Substring(679, 2) + "-" + rawPermitData[i].Substring(681, 2) + "-" + rawPermitData[i].Substring(683, 4);
                    }

                    if(rawPermitData[i].Substring(705, 1) == "Y")
                    {
                        GetRUCExpiry(rego);
                    }

                    FindClient(vin, rego);

                    outputs.Add(rego + "," + vin + "," + regExp + "," + wofExp + "," + cofExp + "," + rucExp + "," + client);
                    //MessageBox.Show("Rego: " + rego + "\nVIN: " + vin + "\nReg Expiry: " + regExp + "\nWOF Expiry: " + wofExp + "\nRUC Expiry: " + rucExp, "Motochek Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetVars();
                }
            }
            File.WriteAllLines("MotoCheckOutput.csv", outputs);
            MessageBox.Show("Motocheck file processing complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetRUCExpiry(String reg)
        {
            //test
            Boolean gotRUC = false;

            for(int i = 0; i < rawRUCData.Length; i++)
            {
                if(i == 0)
                {
                    //ignore first line of the text file
                    continue;
                }
                else
                {
                    if(rawRUCData[i].Substring(1, 6) == reg)
                    {
                        rucExp = rawRUCData[i].Substring(128, 8);
                        gotRUC = true;
                    }
                }
                if(gotRUC)
                {
                    break;
                }
            }
        }

        //processing functions for fuel types
        private void ProcessFuelFile()
        {
            for (int i = 1; i < rawFuelData.Length; i++)
            {
             
                rego = rawFuelData[i].Substring(1, 6);
                vin = rawFuelData[i].Substring(13, 17);
                vehicleYear = rawFuelData[i].Substring(36, 4);
                make = rawFuelData[i].Substring(40, 20);
                model = rawFuelData[i].Substring(60, 20);

                if(rawFuelData[i].Substring(1061, 2) == "01")
                {
                    fuelType = "Petrol";
                } else if (rawFuelData[i].Substring(1061, 2) == "02")
                {
                    fuelType = "Diesel";
                } else if (rawFuelData[i].Substring(1061, 2) == "03")
                {
                    fuelType = "CNG";
                } else if (rawFuelData[i].Substring(1061, 2) == "04")
                {
                    fuelType = "LPG";
                } else if (rawFuelData[i].Substring(1061, 2) == "05")
                {
                    fuelType = "Electric";
                } else
                {
                    fuelType = "Other";
                }

                fuelOutput.Add(rego + "," + vin + "," + vehicleYear + "," + make + "," + model + "," + fuelType);
                //MessageBox.Show("Rego: " + rego + "\nVIN: " + vin + "\nReg Expiry: " + regExp + "\nWOF Expiry: " + wofExp + "\nRUC Expiry: " + rucExp, "Motochek Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetVars();
            
            }
            File.WriteAllLines("FuelTypesOutput.csv", fuelOutput);
            MessageBox.Show("Fuel file processing complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //other functions
        private void ResetVars()
        {
            this.rego = "";
            this.vin = "";
            this.regExp = "";
            this.wofExp = "";
            this.cofExp = "";
            this.rucExp = "0";
            fuelType = "";
            make = "";
            model = "";
            vehicleYear = "0";
            client = "";
        }



        //vin number to username matchup functions
        private void BtnSelectVinFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                vinTextBox.Text = openFileDialog4.FileName;
                vinFileOK = true;
            }
        }

        private void ProcessRawVINData()
        {
            for (int i = 1; i < rawVINData.Length; i++)
            {
                if(rawVINData[i].Length > 10)
                {
                    userNames.Add(rawVINData[i].Substring(0, 9));
                    vinNumbers.Add(rawVINData[i].Substring(10, rawVINData[i].Length - 10));
                }
                else
                {
                    continue;
                }
            }
        }

        private void FindClient(String vinNumber, String rego)
        {
            for(int i = 0; i < vinNumbers.Count; i++)
            {
                if(vinNumbers[i] == vinNumber)
                {
                    client = userNames[i];
                    break;
                }
                if(vinNumbers[i] == rego)
                {
                    client = userNames[i];
                    this.vin = rego;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

    }
}
