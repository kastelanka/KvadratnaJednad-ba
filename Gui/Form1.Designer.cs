
namespace Vsite.CSharp.KvadratnaJednadžba.Gui
{
    partial class QuadraticEquation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultDisplay = new Vsite.CSharp.KvadratnaJednadžba.Gui.ResultDisplay();
            this.functionPanel1 = new Vsite.CSharp.KvadratnaJednadžba.Gui.FunctionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(0, 0);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(231, 337);
            this.resultDisplay.TabIndex = 0;
            // 
            // functionPanel1
            // 
            this.functionPanel1.Location = new System.Drawing.Point(252, 32);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(468, 289);
            this.functionPanel1.TabIndex = 1;
            this.functionPanel1.TabStop = false;
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.resultDisplay);
            this.Name = "QuadraticEquation";
            this.Text = "Qudratic Equation";
            this.Load += new System.EventHandler(this.QuadraticEquation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
        private FunctionPanel functionPanel1;
    }
}

