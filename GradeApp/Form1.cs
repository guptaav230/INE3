using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class LetterGradefrm : Form
    {
        public LetterGradefrm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            
            int numbGrade = int.Parse(numberGradeTb.Text);
            Grade grObj = new Grade();
            grObj.NumberGrade = numbGrade;
            letterGradeTb.Text = grObj.CalculateLetterGrade();
            numberGradeTb.Focus();


        }
        
        private void numberGradeTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculateBtn.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }

  
    }
}
