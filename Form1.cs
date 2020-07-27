using System;
using System.Windows.Forms;

/*  ID
 *      Image Filter Form, Kaleb Ehlert, 2/25/2018
 *  Purpose
 *      The purpose of the program is to take the image on screen apply a blue filter to the image.
 *  Form Controls
 *      picDaisy: A picture control that displays a picture of a daisy.
 *  Code & Logic
 *      The input is the click on the picture box.
 *      The processing is applying the blue filter to the image.
 *      The output is the new image.
 */

namespace EhlertProgram6
{
    public partial class frmImage : Form
    {
        public frmImage()
        {
            InitializeComponent();
        }

        // Applies the blue filter when the picDaisy control is clicked
        private void picDaisy_Click(object sender, EventArgs e)
        {
            // Calls on the blue filter method to apply to the picDaisy control
            picDaisy.Image = picDaisy.Image.ApplyBlueFilter();
        }
    }
}
