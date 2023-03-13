
namespace AppIntroducao.view
{
    partial class FrmComboComCalculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComboComCalculo));
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.cboDropDownList = new System.Windows.Forms.ComboBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPosItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(278, 112);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(121, 20);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(278, 168);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(121, 20);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // cboDropDownList
            // 
            this.cboDropDownList.FormattingEnabled = true;
            this.cboDropDownList.Items.AddRange(new object[] {
            "Adição",
            "Subtração",
            "Multiplicação",
            "Divisão",
            "Divisão de Resto - MOD"});
            this.cboDropDownList.Location = new System.Drawing.Point(278, 222);
            this.cboDropDownList.Name = "cboDropDownList";
            this.cboDropDownList.Size = new System.Drawing.Size(121, 21);
            this.cboDropDownList.TabIndex = 2;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExecutar.Location = new System.Drawing.Point(433, 112);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(117, 50);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblValor1.Location = new System.Drawing.Point(209, 110);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(66, 20);
            this.lblValor1.TabIndex = 5;
            this.lblValor1.Text = "Valor 1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpar.Location = new System.Drawing.Point(433, 193);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblValor2.Location = new System.Drawing.Point(209, 166);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(66, 20);
            this.lblValor2.TabIndex = 8;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblResultado.Location = new System.Drawing.Point(209, 270);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(130, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado aqui";
            // 
            // lblPosItem
            // 
            this.lblPosItem.AutoSize = true;
            this.lblPosItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPosItem.Location = new System.Drawing.Point(209, 314);
            this.lblPosItem.Name = "lblPosItem";
            this.lblPosItem.Size = new System.Drawing.Size(185, 20);
            this.lblPosItem.TabIndex = 10;
            this.lblPosItem.Text = "Posição da Operação:";
            // 
            // FrmComboComCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPosItem);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.cboDropDownList);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComboComCalculo";
            this.Text = "Combo Box com Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.ComboBox cboDropDownList;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPosItem;
    }
}