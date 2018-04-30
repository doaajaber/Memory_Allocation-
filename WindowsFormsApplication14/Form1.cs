using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        int k = 0; 
        List<hole> ListOfHoles = new List<hole>();
        GroupBox Memory_GroupBox = new GroupBox();
        
        Label[] holeslabel;
        Label allocateLabel = new Label(); 
        List<Process> ProcessesList = new List<Process>();
        int numberofpoles=0; 
        public Form1()
        {
            InitializeComponent();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string MemorySizeS = textBox1.Text;
            int MemorySizeI = int.Parse(MemorySizeS);


            string NuHolesS = textBox2.Text;
            int NuHolesI = int.Parse(NuHolesS);



            dataGridView1.RowCount = NuHolesI;

            dataGridView1.Visible = true;
            button2.Visible = true;

            //  hole[] arrayHoles = new hole[NuHolesI];  
            // List<hole> ListOfHoles = new List<hole> ();
            for (int ihole = 0; ihole < NuHolesI; ihole++)
            {
                ListOfHoles.Add(new hole());
                numberofpoles++; 
            }






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {
            /*radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;*/



            /////////////////important \\\\\\\\\\\\\\\\

            // for (int row = 0; row < dataGridView1.Rows.Count; row++)
            //  {

            //      Convert.ToInt32(dataGridView1.Rows[/*index of row*/row].Cells[/*index of column */ 0].Value);
            //      Convert.ToInt32(dataGridView1.Rows[/*index of row*/row].Cells[/*index of column */ 1].Value);


            //  }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ListOfHoles[i].start = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                ListOfHoles[i].size = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                ListOfHoles[i].end = ListOfHoles[i].start + ListOfHoles[i].size;
                ListOfHoles[i].free_size = ListOfHoles[i].size;
                ListOfHoles[i].Empty_address = ListOfHoles[i].start;
            }


            comboBox1.Visible = true;
            label1.Visible = true;
            button3.Visible = true;
            NameProcessLabel.Visible = true;
            SizeProcessLabel.Visible = true;
            textbox_NameOfProcess.Visible = true;
            textbox_SizeOfProcess.Visible = true;
            //    labelMEM.Visible = true;
            //   groupBoxMEM.Visible = true; 
            //  Memory_GroupBox.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            button4.Visible = true; 


            Drawing(ListOfHoles);
            Drawing1(ListOfHoles); 



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="ArrayOfHoles"></param>
        /// <param name="first"></param>
        /// 



        public void Drawing1(List<hole> ArrayOfHoles)
        {
            Label[] startingaddlabel = new Label[numberofpoles];
            Label[] endingaddlabel = new Label[numberofpoles];
            int x = 620;
            int firstlabel = 100;
            

            if (k != 0)
            {
                for (int l = 0; l < numberofpoles; l++)
                {
                    startingaddlabel[l].Visible = false;
                    endingaddlabel[l].Visible = false;


                }
            }

               for (int i = 0; i < numberofpoles; i++)
            {


                k++; 
                   
                   // int y = firstlabel + 2 * (ArrayOfHoles[i].start);

                //  670, 100
                //   int x = 620;
                //   int y = firstlabel + 2 * (ArrayOfHoles[i].start);
                startingaddlabel[i] = new Label();
                startingaddlabel[i].Location = new Point(x, firstlabel + 2 * (ArrayOfHoles[i].start));
                startingaddlabel[i].Text = (ArrayOfHoles[i].start).ToString();

                endingaddlabel[i] = new Label();
                endingaddlabel[i].Location = new Point(x, firstlabel + 2 * (ArrayOfHoles[i].start) + 2 * ArrayOfHoles[i].size);
                endingaddlabel[i].Text = (ArrayOfHoles[i].start + ArrayOfHoles[i].size).ToString();




                this.Controls.Add(startingaddlabel[i]);
                this.Controls.Add(endingaddlabel[i]);






            }

            //// first label 
         //   int firstlabel = 100;
            Label firstlabelL = new Label();
            firstlabelL.Location = new Point(620, firstlabel);
            firstlabelL.Text = "0";
            this.Controls.Add(firstlabelL);



            ///last label 
            int sizeofmem = Convert.ToInt32(textBox1.Text);
             int lastlabel = firstlabel + 2 * sizeofmem;
              Label lastlabelL = new Label();
              lastlabelL.Location = new Point(620, lastlabel);
              lastlabelL.Text = sizeofmem.ToString();
              this.Controls.Add(lastlabelL);
        }







        public void Drawing(List<hole> ArrayOfHoles)
        {

            labelMEM.Visible = true;
            groupBoxMEM.Visible = true;
         //   holefix(ArrayOfHoles); 
            numberofpoles = ArrayOfHoles.Count; 
          //  numberofpoles = Convert.ToInt32(textBox2.Text);
            holeslabel = new Label[numberofpoles];
            int sizeofmem = Convert.ToInt32(textBox1.Text);


            groupBoxMEM.Height = 2 * sizeofmem;


            /// starting address drawing 
            //    int numberofpoles = Convert.ToInt32(textBox2.Text) ;
            //    int sizeofmem = Convert.ToInt32(textBox1.Text); 
            Label[] startingaddlabel = new Label[numberofpoles];
            Label[] endingaddlabel = new Label[numberofpoles];







            for (int c = 0; c < numberofpoles; c++)
            {

                holeslabel[c] = new Label();
                holeslabel[c].Location = new Point(0, 2 * ArrayOfHoles[c].start);
                holeslabel[c].Height = 2 * ArrayOfHoles[c].size;
                holeslabel[c].BackColor = System.Drawing.Color.Green;
                holeslabel[c].BorderStyle = BorderStyle.Fixed3D;

                holeslabel[c].Width = groupBoxMEM.Width;
                holeslabel[c].Text = "Hole! size: " + ArrayOfHoles[c].size;


                groupBoxMEM.Controls.Add(holeslabel[c]);


            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string processName = textbox_NameOfProcess.Text;
            int processSize = Convert.ToInt32(textbox_SizeOfProcess.Text);
            string method = comboBox1.Text;
            Process p = new Process(processSize, processName);
            p.process_name = textbox_NameOfProcess.Text; ;
            ProcessesList.Add(p); 


             
            
            for (int b = 0; b < numberofpoles; b++)
            {
                holeslabel[b].Visible = false;
            }

            //  Drawing(ListOfHoles);
            Allocating(method, p);


            //// Test the function ////
          //  MessageBox.Show(p.process_name + "//" + p.p_start_address + "//" + p.Process_size + "//" + p.End_p_address);





        }
        public void Allocating(string Technique, Process p)
        {
            ////Fist Fit Function 

            hole myhole = new hole();
            int n = 0;
            int what=0 ; 
            if (Technique == "First Fit")
            {


                for (n = 0; n < ListOfHoles.Count; n++)
                {
                    if (ListOfHoles[n].size >= p.Process_size)
                    {
                        myhole = ListOfHoles[n];
                        what = 0; 
                        break;

                    }


                    what = 1; 

                }


                if (what == 0)
                {
                    /// process take the hole information :
                    p.p_start_address = myhole.start;
                    p.End_p_address = p.p_start_address + p.Process_size;


                    ///update the hole information :
                    ListOfHoles[n].start += p.Process_size;
                    ListOfHoles[n].size -= p.Process_size;


                    //Drawing the holes 
                    Drawing(ListOfHoles);


                    //drawing the new process : 
                    Label allocateLabel = new Label();
                    allocateLabel.Location = new Point(0, 2 * p.p_start_address);
                    allocateLabel.Height = 2 * p.Process_size;
                    allocateLabel.BackColor = System.Drawing.Color.Red;
                    allocateLabel.BorderStyle = BorderStyle.Fixed3D;

                    allocateLabel.Width = groupBoxMEM.Width;
                    allocateLabel.Text = p.process_name;
                    groupBoxMEM.Controls.Add(allocateLabel);




                    //// draw Label :starting address of process 
                    int  firstlabel = 100; 
                    Label firstlabelL = new Label();
                    firstlabelL.Location = new Point(620,firstlabel+2*(p.p_start_address +p.Process_size));
                    firstlabelL.Text = p.End_p_address.ToString();
                    this.Controls.Add(firstlabelL);
                    

                    
                }
                if (what == 1)
                {

                    Drawing(ListOfHoles);
                    MessageBox.Show("Sorry.There is not enough space. Please remove a process from Memory and try again . ");

                }
            }




//////Best FIT 
            else if (Technique == "Best Fit")
            {
                List<hole> copy = new List<hole>(ListOfHoles);
                copy = ListOfHoles.ToList();

                copy.Sort((x, y) => x.size.CompareTo(y.size));

                for (n = 0; n < copy.Count; n++)
                {
                    if (copy[n].size >= p.Process_size)
                    {
                        myhole = copy[n];
                        what = 0; 
                        break;

                    }
                    what = 1; 
                }
                if (what == 0)
                {
                    p.p_start_address = copy[n].start;
                    p.End_p_address = p.p_start_address + p.Process_size;


                    ///update the hole information :
                    copy[n].start += p.Process_size;
                    copy[n].size -= p.Process_size;


                    //Drawing the holes 
                    Drawing(copy);


                    //drawing the new process : 
                    Label allocateLabel = new Label();
                    allocateLabel.Location = new Point(0, 2 * p.p_start_address);
                    allocateLabel.Height = 2 * p.Process_size;
                    allocateLabel.BackColor = System.Drawing.Color.Red;
                    allocateLabel.BorderStyle = BorderStyle.Fixed3D;

                    allocateLabel.Width = groupBoxMEM.Width;
                    allocateLabel.Text = p.process_name;
                    groupBoxMEM.Controls.Add(allocateLabel);


                    ///update original hole info 

                    int v = 0;
                    int k = 0;

                    for (v = 0; v < ListOfHoles.Count; v++)
                    {
                        for (k = v; k < ListOfHoles.Count; k++)
                        {
                            if (ListOfHoles[v].size == copy[k].size)
                            {
                                break;
                            }
                            // break; 
                        }

                        break;
                    }

                    ListOfHoles[v].size = copy[k].size;
                    ListOfHoles[v].start = copy[k].start;





                    //// draw Label :starting address of process 
                    int firstlabel = 100;
                    Label firstlabelL = new Label();
                    firstlabelL.Location = new Point(620, firstlabel + 2 * (p.p_start_address + p.Process_size));
                    firstlabelL.Text = p.End_p_address.ToString();
                    this.Controls.Add(firstlabelL);

                }


                if (what == 1)
                {
                    Drawing(ListOfHoles);
                    MessageBox.Show("Sorry.There is not enough space. Please remove a process from Memory and try again . ");
                }
                
            }


            ///Worst Fit :
            ///





            else if (Technique == "Worst Fit")
            {


                List<hole> copy = new List<hole>(ListOfHoles);
                copy = ListOfHoles.ToList();

                copy.Sort((x, y) => x.size.CompareTo(y.size));

           
                n = copy.Count() - 1;
                if (copy[n].size >= p.Process_size)
                {

                    myhole = copy[n];


                    p.p_start_address = copy[n].start;
                    p.End_p_address = p.p_start_address + p.Process_size;


                    ///update the hole information :
                    copy[n].start += p.Process_size;
                    copy[n].size -= p.Process_size;


                    //Drawing the holes 
                    Drawing(copy);


                    //drawing the new process : 
                    Label allocateLabel = new Label();
                    allocateLabel.Location = new Point(0, 2 * p.p_start_address);
                    allocateLabel.Height = 2 * p.Process_size;
                    allocateLabel.BackColor = System.Drawing.Color.Red;
                    allocateLabel.BorderStyle = BorderStyle.Fixed3D;

                    allocateLabel.Width = groupBoxMEM.Width;
                    allocateLabel.Text = p.process_name;
                    groupBoxMEM.Controls.Add(allocateLabel);



                    ///update original hole info 

                    int v = 0;
                    int k = 0;

                    for (v = 0; v < ListOfHoles.Count; v++)
                    {
                        for (k = v; k < ListOfHoles.Count; k++)
                        {
                            if (ListOfHoles[v].size == copy[k].size)
                            {
                                break;
                            }
                            // break; 
                        }

                        break;
                    }

                    ListOfHoles[v].size = copy[k].size;
                    ListOfHoles[v].start = copy[k].start;





                    //// draw Label :starting address of process 
                    int firstlabel = 100;
                    Label firstlabelL = new Label();
                    firstlabelL.Location = new Point(620, firstlabel + 2 * (p.p_start_address + p.Process_size));
                    firstlabelL.Text = p.End_p_address.ToString();
                    this.Controls.Add(firstlabelL);



                }
                else
                {
                    Drawing(ListOfHoles);
                    MessageBox.Show("Sorry.There is not enough space. Please remove a process from Memory and try again . ");
                }


            }
            

        }




        ///// DEallocate Function ::: يا رب انت عارف 




     /*  public void holefix(List<hole> ArrayOfHoles)
        {

            ArrayOfHoles.Sort((x, y) => x.start.CompareTo(y.start));

            for (int x = 0; x <= ArrayOfHoles.Count-2; x++)
            {

                if (ArrayOfHoles[x].end >= ArrayOfHoles[x + 1].start)
                {
                    hole newhole = new hole();
                    newhole.start = ArrayOfHoles[x].start;
                    newhole.end = ArrayOfHoles[x + 1].end;
                    newhole.size = ArrayOfHoles[x + 1].end - ArrayOfHoles[x].start;
                    ArrayOfHoles.RemoveAt(x + 1);
                    ArrayOfHoles.RemoveAt(x);
                    
                    ArrayOfHoles.Add(newhole); 


                }



                


            }
            

        }
        */
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string procrssName = textBox4.Text; 

            int DeAllocate ;

            for (DeAllocate = 0; DeAllocate <= ProcessesList.Count()-1; DeAllocate++)

            { 
            
            if (ProcessesList[DeAllocate].process_name == procrssName)
                {

                    groupBoxMEM.Controls.Clear();

                    hole backhole = new hole();
                    backhole.start = (ProcessesList[DeAllocate]).p_start_address;
                    backhole.size = (ProcessesList[DeAllocate]).Process_size;
                    backhole.end = (ProcessesList[DeAllocate]).End_p_address;





                    ListOfHoles.Add(backhole);


                    ListOfHoles.Sort((x, y) => x.start.CompareTo(y.start));
                    ProcessesList.RemoveAt(DeAllocate); 

                
                  //  Drawing1(ListOfHoles);
                    Drawing(ListOfHoles); 
                DrawingProcesses(ProcessesList) ;
            }
            
            
            
            }
        }
        public void DrawingProcesses(List<Process> ProcessesList)
        {
            for (int u = 0; u < ProcessesList.Count; u++)
            {
                Label allocateLabel = new Label();
                allocateLabel.Location = new Point(0, 2 * ProcessesList[u].p_start_address);
                allocateLabel.Height = 2 * ProcessesList[u].Process_size;
                allocateLabel.BackColor = System.Drawing.Color.Red;
                allocateLabel.BorderStyle = BorderStyle.Fixed3D;

                allocateLabel.Width = groupBoxMEM.Width;
                allocateLabel.Text = ProcessesList[u].process_name;
                groupBoxMEM.Controls.Add(allocateLabel);

            }


        }









    }
}



