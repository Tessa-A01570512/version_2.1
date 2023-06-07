namespace version_two
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cantidad_clientes = new System.Windows.Forms.TextBox();
            this.camiones_disponibles = new System.Windows.Forms.TextBox();
            this.demanda_minima = new System.Windows.Forms.TextBox();
            this.demanda_maxima = new System.Windows.Forms.TextBox();
            this.capacidad_camion = new System.Windows.Forms.TextBox();
            this.lambda = new System.Windows.Forms.TextBox();
            this.simular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.entregas_ok = new System.Windows.Forms.TextBox();
            this.entregas_porcentaje = new System.Windows.Forms.TextBox();
            this.capacidad_total = new System.Windows.Forms.TextBox();
            this.capacidad_en_tiempo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.borrar_valores = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidad_clientes
            // 
            this.cantidad_clientes.Location = new System.Drawing.Point(166, 12);
            this.cantidad_clientes.Name = "cantidad_clientes";
            this.cantidad_clientes.Size = new System.Drawing.Size(100, 23);
            this.cantidad_clientes.TabIndex = 0;
            this.cantidad_clientes.TextChanged += new System.EventHandler(this.cantidad_clientes_TextChanged);
            // 
            // camiones_disponibles
            // 
            this.camiones_disponibles.Location = new System.Drawing.Point(166, 41);
            this.camiones_disponibles.Name = "camiones_disponibles";
            this.camiones_disponibles.Size = new System.Drawing.Size(100, 23);
            this.camiones_disponibles.TabIndex = 1;
            this.camiones_disponibles.TextChanged += new System.EventHandler(this.camiones_disponibles_TextChanged);
            // 
            // demanda_minima
            // 
            this.demanda_minima.Location = new System.Drawing.Point(166, 70);
            this.demanda_minima.Name = "demanda_minima";
            this.demanda_minima.Size = new System.Drawing.Size(100, 23);
            this.demanda_minima.TabIndex = 2;
            this.demanda_minima.TextChanged += new System.EventHandler(this.demanda_minima_TextChanged);
            // 
            // demanda_maxima
            // 
            this.demanda_maxima.Location = new System.Drawing.Point(166, 99);
            this.demanda_maxima.Name = "demanda_maxima";
            this.demanda_maxima.Size = new System.Drawing.Size(100, 23);
            this.demanda_maxima.TabIndex = 3;
            this.demanda_maxima.TextChanged += new System.EventHandler(this.demanda_maxima_TextChanged);
            // 
            // capacidad_camion
            // 
            this.capacidad_camion.Location = new System.Drawing.Point(166, 128);
            this.capacidad_camion.Name = "capacidad_camion";
            this.capacidad_camion.Size = new System.Drawing.Size(100, 23);
            this.capacidad_camion.TabIndex = 4;
            this.capacidad_camion.TextChanged += new System.EventHandler(this.capacidad_camion_TextChanged);
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(166, 157);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(100, 23);
            this.lambda.TabIndex = 6;
            this.lambda.TextChanged += new System.EventHandler(this.lambda_TextChanged);
            // 
            // simular
            // 
            this.simular.Location = new System.Drawing.Point(5, 186);
            this.simular.Name = "simular";
            this.simular.Size = new System.Drawing.Size(261, 23);
            this.simular.TabIndex = 7;
            this.simular.Text = "Comenzar Simulación";
            this.simular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Camiones disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Demanda mínima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Demanda máxima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Capacidad del camión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lambda";
            // 
            // entregas_ok
            // 
            this.entregas_ok.Location = new System.Drawing.Point(166, 215);
            this.entregas_ok.Name = "entregas_ok";
            this.entregas_ok.Size = new System.Drawing.Size(100, 23);
            this.entregas_ok.TabIndex = 15;
            // 
            // entregas_porcentaje
            // 
            this.entregas_porcentaje.Location = new System.Drawing.Point(166, 244);
            this.entregas_porcentaje.Name = "entregas_porcentaje";
            this.entregas_porcentaje.Size = new System.Drawing.Size(100, 23);
            this.entregas_porcentaje.TabIndex = 16;
            // 
            // capacidad_total
            // 
            this.capacidad_total.Location = new System.Drawing.Point(166, 273);
            this.capacidad_total.Name = "capacidad_total";
            this.capacidad_total.Size = new System.Drawing.Size(100, 23);
            this.capacidad_total.TabIndex = 17;
            // 
            // capacidad_en_tiempo
            // 
            this.capacidad_en_tiempo.Location = new System.Drawing.Point(166, 302);
            this.capacidad_en_tiempo.Name = "capacidad_en_tiempo";
            this.capacidad_en_tiempo.Size = new System.Drawing.Size(100, 23);
            this.capacidad_en_tiempo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Entregas en tiempo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Entregas Totales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Capacidad Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Capacidad en tiempo";
            // 
            // borrar_valores
            // 
            this.borrar_valores.Location = new System.Drawing.Point(5, 331);
            this.borrar_valores.Name = "borrar_valores";
            this.borrar_valores.Size = new System.Drawing.Size(261, 23);
            this.borrar_valores.TabIndex = 23;
            this.borrar_valores.Text = "Borrar Datos";
            this.borrar_valores.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(272, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(815, 371);
            this.dgv.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 395);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.borrar_valores);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.capacidad_en_tiempo);
            this.Controls.Add(this.capacidad_total);
            this.Controls.Add(this.entregas_porcentaje);
            this.Controls.Add(this.entregas_ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simular);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.capacidad_camion);
            this.Controls.Add(this.demanda_maxima);
            this.Controls.Add(this.demanda_minima);
            this.Controls.Add(this.camiones_disponibles);
            this.Controls.Add(this.cantidad_clientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cantidad_clientes;
        private TextBox camiones_disponibles;
        private TextBox demanda_minima;
        private TextBox demanda_maxima;
        private TextBox capacidad_camion;
        private TextBox lambda;
        private Button simular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox entregas_ok;
        private TextBox entregas_porcentaje;
        private TextBox capacidad_total;
        private TextBox capacidad_en_tiempo;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button borrar_valores;
        private DataGridView dgv;
    }
}