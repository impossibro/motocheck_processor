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

        private String[] rawPermitData;
        private String[] rawRUCData;

        private String rego;
        private String vin;
        private String regExp;
        private String wofExp;
        private String rucExp;

        private List<String> outputs;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetVars();
            outputs = new List<String>();
            //create headings for CSV
            outputs.Add("rego,vin,regExp,wofExp,rucExp");
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                file1OK = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
                file2OK = true;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //check if both files have been selected and then process them.
            if (file1OK && file2OK)
            {
                rawPermitData = File.ReadAllLines(textBox1.Text);
                rawRUCData = File.ReadAllLines(textBox2.Text);
                ProcessRegWOFFile();
            }
            else
            {
                MessageBox.Show("Please select both files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


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
                    rego = rawPermitData[i].Substring(1, 6);
                    vin = rawPermitData[i].Substring(13, 17);
                    regExp = rawPermitData[i].Substring(627, 2) + "-" + rawPermitData[i].Substring(629, 2) + "-" + rawPermitData[i].Substring(631, 4);
                    
                    if(rawPermitData[i].Substring(687, 1) == "Y")
                    {
                        wofExp = rawPermitData[i].Substring(697, 2) + "-" + rawPermitData[i].Substring(699, 2) + "-" + rawPermitData[i].Substring(701, 4);
                    }
                    else
                    {
                        wofExp = rawPermitData[i].Substring(679, 2) + "-" + rawPermitData[i].Substring(681, 2) + "-" + rawPermitData[i].Substring(683, 4);
                    }

                    if(rawPermitData[i].Substring(705, 1) == "Y")
                    {
                        GetRUCExpiry(rego);
                    }

                    outputs.Add(rego + "," + vin + "," + regExp + "," + wofExp + "," + rucExp);
                    //MessageBox.Show("Rego: " + rego + "\nVIN: " + vin + "\nReg Expiry: " + regExp + "\nWOF Expiry: " + wofExp + "\nRUC Expiry: " + rucExp, "Motochek Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetVars();
                }
            }
            File.WriteAllLines("MotoCheckOutput.csv", outputs);
            MessageBox.Show("Motocheck file processing complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetRUCExpiry(String reg)
        {
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

        private void ResetVars()
        {
            this.rego = "";
            this.vin = "";
            this.regExp = "";
            this.wofExp = "";
            this.rucExp = "0";
        }


    }
}
