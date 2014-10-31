namespace Minesweeper.View
{
    partial class BoardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridBoard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBoard
            // 
            this.gridBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBoard.Location = new System.Drawing.Point(3, 3);
            this.gridBoard.Name = "gridBoard";
            this.gridBoard.Size = new System.Drawing.Size(484, 351);
            this.gridBoard.TabIndex = 0;
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBoard);
            this.Name = "BoardView";
            this.Size = new System.Drawing.Size(490, 354);
            ((System.ComponentModel.ISupportInitialize)(this.gridBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBoard;
    }
}
