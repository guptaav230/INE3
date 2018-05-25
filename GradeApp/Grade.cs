using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    class Grade
    {
        #region field variable
        private int _NumberGrade;
        #endregion

        #region Getters and Setters
        public int NumberGrade
        {
            get
            {
                return _NumberGrade;
            }

            set
            {
                _NumberGrade = value;
            }
        }
        #endregion

        #region other Methods
        // Method to calculate grade depending upon number grade
        public string CalculateLetterGrade() {
            if (_NumberGrade >= 90 && _NumberGrade <= 100) {
                return "A+";
            }
            else if (_NumberGrade >= 85 && _NumberGrade <= 89) {
                return "A";
            }
            else if (_NumberGrade >= 80 && _NumberGrade <= 84)
            {
                return "A-";
            }
            else if (_NumberGrade >= 75 && _NumberGrade <= 79)
            {
                return "B+";
            }
            else if (_NumberGrade >= 70 && _NumberGrade <= 74)
            {
                return "B-";
            }
            else if (_NumberGrade >= 65 && _NumberGrade <= 69)
            {
                return "C+";
            }
            else if (_NumberGrade >= 60 && _NumberGrade <= 64)
            {
                return "C";
            }
            else if (_NumberGrade >= 55 && _NumberGrade <= 59)
            {
                return "D+";
            }
            else if (_NumberGrade >= 50 && _NumberGrade <= 54)
            {
                return "D-";
            }
            else if (_NumberGrade >= 0 && _NumberGrade <= 49)
            {
                return "F";
            }
            return "Invalid Entry !! ";
        }
        #endregion


    }
}
