﻿using Smobiler.Core;

namespace SmobilerApplication1
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "button2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.Text = "button3";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button2,
            this.button3});
            this.Name = "SmobilerForm1";

        }
        #endregion
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
    }
}