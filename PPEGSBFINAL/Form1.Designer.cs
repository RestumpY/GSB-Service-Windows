
namespace PPEGSBFINAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ChangeEtat = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbMoisPrec = new System.Windows.Forms.Label();
            this.idVisiteur = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(27, 22);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1029, 253);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick_1);
            // 
            // ChangeEtat
            // 
            this.ChangeEtat.Location = new System.Drawing.Point(119, 378);
            this.ChangeEtat.Name = "ChangeEtat";
            this.ChangeEtat.Size = new System.Drawing.Size(169, 49);
            this.ChangeEtat.TabIndex = 1;
            this.ChangeEtat.Text = "Changer Etat";
            this.ChangeEtat.UseVisualStyleBackColor = true;
            this.ChangeEtat.Click += new System.EventHandler(this.ChangeEtat_Click_1);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(614, 331);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(122, 20);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Date aujourdhui";
            // 
            // lbMoisPrec
            // 
            this.lbMoisPrec.AutoSize = true;
            this.lbMoisPrec.Location = new System.Drawing.Point(614, 426);
            this.lbMoisPrec.Name = "lbMoisPrec";
            this.lbMoisPrec.Size = new System.Drawing.Size(129, 20);
            this.lbMoisPrec.TabIndex = 4;
            this.lbMoisPrec.Text = "Date precedente";
            // 
            // idVisiteur
            // 
            this.idVisiteur.Location = new System.Drawing.Point(152, 331);
            this.idVisiteur.Name = "idVisiteur";
            this.idVisiteur.Size = new System.Drawing.Size(100, 26);
            this.idVisiteur.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 517);
            this.Controls.Add(this.idVisiteur);
            this.Controls.Add(this.lbMoisPrec);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.ChangeEtat);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ChangeEtat;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbMoisPrec;
        private System.Windows.Forms.TextBox idVisiteur;
        private System.Windows.Forms.Timer timer1;
    }
}

