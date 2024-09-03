
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;

namespace Gerenciamento_de_Supermercado
{
    public partial class Form1 : Form
    {  
        string telaAtual = "🛒 Compras";
        bool stateCompraRadioButton = false;
        int lastIdBuy = 0;

        Dictionary<string, Dictionary<string, string>> EstoqueData = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> EstoqueDataPendente = new Dictionary<string, Dictionary<string, string>>();

        private Dictionary<string, Dictionary<string, object>> ComprasData = new Dictionary<string, Dictionary<string, object>>();
        Dictionary<string, System.Windows.Forms.Panel> cloneRowsPanel = new Dictionary<string, System.Windows.Forms.Panel>();
        Dictionary<string, Dictionary<string, System.Windows.Forms.Label>> cloneRowsLabel = new Dictionary<string, Dictionary<string, Label>>();

        Dictionary<string, Dictionary<string, Dictionary<string, string>>> EstoqueComparativo = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

        List<string> Alertas = new List<string>();

        Dictionary<string, Panel> estoqueRowsPanel = new Dictionary<string, Panel>(); 

        string currentEstoque = "EstoqueData";

        string JsonFileData = "";
        int productQuant = 0;
        int totalQuant = 0;

        int AlertaRowCounter = 0;
        int HistRowCounter = 0;

        int lastId;

        public Form1()
        {   
            InitializeComponent();
            returnCompraData();
            compra_label_returnDayBuy.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            EstoqueComboBox.Text = "Atual";
        }

        void createRow(string id, string color)
        {
            cloneRowsPanel[id] = new Panel();
            AlertaPanel1.Controls.Add(cloneRowsPanel[id]);

            if (color == "min")
                cloneRowsPanel[id].BackColor = Color.FromArgb(255, 255, 102, 102);
            else
                cloneRowsPanel[id].BackColor = Color.FromArgb(255, 255, 255, 153);

            cloneRowsPanel[id].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cloneRowsPanel[id].Location = new System.Drawing.Point(3, 0 + (51 * AlertaRowCounter));
            cloneRowsPanel[id].Name = "TemplatePanel";
            cloneRowsPanel[id].Size = new System.Drawing.Size(1140, 53);


            int tempCounter = 0;
            foreach (KeyValuePair<string, string> value in new Dictionary<string, string> 
            {
                { "ID: ", "Id" },
                { "Nome do Produto: ", "Nome" },
                { "Categoria: ", "Categoria"},
                { "Setor:",  "Setor"},
                { "Preço", "Preco"},
                { "Quantidade Disponível", "Quant" },
                { "Alerta (Máximo)", "AlertaMax" },
                { "Alerta (Mínimo)", "AlertaMin" }
                })
            {
                cloneRowsLabel[id] = new Dictionary<string, Label>();
                cloneRowsLabel[id][value.Key] = new Label();
                cloneRowsPanel[id].Controls.Add(cloneRowsLabel[id][value.Key]);
                cloneRowsLabel[id][value.Key].AutoSize = true;
                cloneRowsLabel[id][value.Key].Location = new System.Drawing.Point(4 + (150 * tempCounter), 4);
                cloneRowsLabel[id][value.Key].Size = new System.Drawing.Size(80, 13);
                cloneRowsLabel[id][value.Key].TabIndex = 0;
                if (tempCounter == 0)
                    cloneRowsLabel[id][value.Key].Text = $"{value.Key}\n{id}";
                else
                    cloneRowsLabel[id][value.Key].Text = $"{value.Key}\n{EstoqueData[id][value.Value]}";
                tempCounter++;
                Alertas.Add(id);
            }

        }

        void estoqueHistCreateRow(string id)
        {
            Panel panel1 = new Panel();

            Label TitleLabel = new Label();
            EstoqueHistPanel.Controls.Add(TitleLabel);
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = System.Drawing.Color.Transparent;
            TitleLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
            if (HistRowCounter == 0)
                TitleLabel.Location = new System.Drawing.Point(0, 0);
            else
                TitleLabel.Location = new System.Drawing.Point(0, (150 * HistRowCounter));
            TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            TitleLabel.Size = new System.Drawing.Size(20, 20);
            TitleLabel.Text = $"ID de Alteração: {id}";

            estoqueRowsPanel[id] = new Panel(); //O Unico Motivo para esse painel estar em um dicionario é para conferir se ja existe uma fileira com esse id.
            EstoqueHistPanel.Controls.Add(estoqueRowsPanel[id]);
            estoqueRowsPanel[id].BorderStyle = BorderStyle.FixedSingle;
            estoqueRowsPanel[id].Location = new System.Drawing.Point(3, (150 * HistRowCounter)+ 37);
            estoqueRowsPanel[id].Name = "EstoqueHistPanel";
            estoqueRowsPanel[id].Size = new System.Drawing.Size(1110, 106);
            estoqueRowsPanel[id].Controls.Add(panel1);

            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new System.Drawing.Point(-1, 0 + (53));
            panel1.Name = "Panel1";
            panel1.Size = new System.Drawing.Size(1110, 53);

            createHistLabel(panel1, "Novo", id);
            createHistLabel(estoqueRowsPanel[id], "Antigo", id);
            HistRowCounter++;
        }
        void refreshEstoqueHist()
        {
            EstoqueHistPanel.Controls.Clear();
            estoqueRowsPanel = new Dictionary<string, Panel>();
            HistRowCounter = 0;

            List<string> invertedKeys = EstoqueComparativo.Keys.ToList();
            invertedKeys.Reverse();

            foreach (string key in invertedKeys)
            {
                if (!estoqueRowsPanel.ContainsKey(key))
                    estoqueHistCreateRow(key);
            }
        }

        void createHistLabel(Panel painel, string tempo, string id)
        {
            Label panel1Label = new Label();
            painel.Controls.Add(panel1Label);
            panel1Label.AutoSize = true;
            panel1Label.BackColor = System.Drawing.Color.Transparent;
            panel1Label.ImeMode = System.Windows.Forms.ImeMode.Off;
            panel1Label.Location = new System.Drawing.Point(520, 0);
            panel1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            panel1Label.Name = "panel1Label";
            panel1Label.Size = new System.Drawing.Size(20, 20);
            panel1Label.TabIndex = 8;
            panel1Label.Text = tempo;

            int collumnCounter = 0;
            foreach (string value in new List<string> { "Id", "Nome", "Categoria", "Setor", "Preço", "Quantidade", "Alerta (Máximo)", "Alerta (Mínimo)" })
            {
                string text = value;
                if (value == "Preço")
                    text = "Preco";
                else if (value == "Quantidade")
                    text = "Quant";
                else if (value == "Alerta (Máximo)")
                    text = "AlertaMax";
                else if (value == "Alerta (Mínimo)")
                    text = "AlertaMin";

                var tempLabel = new Label();
                painel.Controls.Add(tempLabel);
                tempLabel.AutoSize = true;
                tempLabel.BackColor = System.Drawing.Color.Transparent;
                tempLabel.ImeMode = System.Windows.Forms.ImeMode.Off;
                tempLabel.Location = new System.Drawing.Point(20 + 130 * collumnCounter, 30);
                tempLabel.Name = "tempLabel";
                tempLabel.Size = new System.Drawing.Size(13, 13);
                tempLabel.TabIndex = 8;

                if (EstoqueComparativo[id]["Antigo"].ContainsKey(text) && EstoqueComparativo[id]["Novo"].ContainsKey(text))        
                {
                    if (EstoqueComparativo[id]["Antigo"][text] != EstoqueComparativo[id]["Novo"][text])
                    {
                        switch (tempo)
                        {
                            case "Novo":
                                tempLabel.BackColor = Color.FromArgb(237, 237, 131);
                                break;
                            case "Antigo":
                                tempLabel.BackColor = Color.FromArgb(255, 69, 0);
                                break;
                        }
                    }                     
                } 

                if (value != "Id")
                    tempLabel.Text = $"{value}: {EstoqueComparativo[id][tempo][text]}";
                else
                    tempLabel.Text = $"{text}: {id}";

                collumnCounter++;
            }
        }


        private void AlertaPanel1_Paint(object sender, PaintEventArgs e)
        {
            AlertaPanel1.AutoScroll = true;
            AlertaPanel1.HorizontalScroll.Maximum = 0;
        }

        void refreshAlerta()
        {
            try
            {
                foreach (string id in EstoqueData.Keys)
                {
                    if (Convert.ToInt16(EstoqueData[id]["Quant"]) <= Convert.ToInt16(EstoqueData[id]["AlertaMin"]) && !Alertas.Contains(id))
                    {
                        createRow(id, "min");
                        AlertaRowCounter += 1;
                    }
                    else if (Convert.ToInt16(EstoqueData[id]["Quant"]) >= Convert.ToInt16(EstoqueData[id]["AlertaMax"]) && !Alertas.Contains(id))
                    {
                        createRow(id, "max");
                        AlertaRowCounter += 1;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Criar Fileira");
            }
            label_alerta.Text = Convert.ToString(AlertaRowCounter);
        }

        void updateTime()
        {
            compra_returnTimeBuy.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
            Task.Delay(60000).ContinueWith(t => updateTime());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            updateTime();
            splitContainer1.IsSplitterFixed = true;
            if (!File.Exists("EstoqueData.json"))
                File.Create("EstoqueData.json").Dispose();

            if (!File.Exists("EstoqueDataPendente.json"))
                File.Create("EstoqueDataPendente.json").Dispose();

            if (!File.Exists("registerBuys.json"))
                File.Create("registerBuys.json").Dispose();

            if (!File.Exists("estoqueHistorico.json"))
                File.Create("estoqueHistorico.json").Dispose();

            try
            {
                var text = File.ReadAllText("EstoqueData.json");
                EstoqueData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(text);

                text = File.ReadAllText("EstoqueDataPendente.json");
                EstoqueDataPendente = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(text);

                text = File.ReadAllText("estoqueHistorico.json");
                EstoqueComparativo = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(text);
            }
            catch
            {
                Console.WriteLine("Nada aqui");
            }

            try {
                compra_comboBox.DataSource = new BindingSource(EstoqueData.Keys, null);
            }
            catch {
                Console.WriteLine("Nada a carregar");
            }
            reloadEstoque();
            refreshAlerta();
            refreshEstoqueHist();
            updateTelaDeCompra();
        }

        private void reloadEstoque()
        {
            var estoqueAux = EstoqueData;
            if (currentEstoque == "EstoqueData")
                estoqueAux = EstoqueData;
            else if (currentEstoque == "EstoqueDataPendente")
                estoqueAux = EstoqueDataPendente;
            else
                estoqueAux = EstoqueData;

            try
            {
                EstoqueDataGrid.Rows.Clear();
                foreach (string data in estoqueAux.Keys)
                {
                    EstoqueDataGrid.Rows.Add();
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[0].Value = data;
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[1].Value = estoqueAux[data]["Nome"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[2].Value = estoqueAux[data]["Categoria"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[3].Value = estoqueAux[data]["Setor"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[4].Value = estoqueAux[data]["Quant"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[5].Value = estoqueAux[data]["Preco"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[6].Value = estoqueAux[data]["Desc"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[7].Value = estoqueAux[data]["AlertaMin"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[8].Value = estoqueAux[data]["AlertaMax"];
                }
            }

            catch
            {
                Console.WriteLine("ERROR WHILE READING FILE");
            }
            refreshAlerta();
        }

        private void dashboardButton_click(object sender, EventArgs e)
        {
            telaAtual = (sender as Button).Text;
            if (telaAtual == "🛒 Compras")
            {
                returnListBuy.SelectedIndex = 0;
            }
            else if (telaAtual == "📖 Histórico ")
            {
                returnListBuy.SelectedIndex = 1;
                GenerateHistoryBuysScreen();
            }
            else if (telaAtual == "📦 Estoque")
            {
                returnListBuy.SelectedIndex = 2;
                reloadEstoque();
            }
            else if (telaAtual == "Alertas")
            {
                refreshAlerta();
                returnListBuy.SelectedIndex = 3;
            }
            else if (telaAtual == "🚪 Sair")
            {
                this.Close();
            }
            updateTelaDeCompra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EstoqueTextbox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (compra_comboBox.Text == "" || compra_comboBox.Text == "(Coleção)")
            {
                MessageBox.Show("Digite um ID");
            }

            else
            {
                bool addCompra = false;
                foreach (DataGridViewRow row in compra_dataView.Rows)
                {
                    if (compra_comboBox.Text == (string)row.Cells[0].Value)
                    {
                        addCompra = true;
                    }
                }

                if (addCompra && Convert.ToInt16(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value) < Convert.ToInt16(EstoqueData[compra_comboBox.Text]["Quant"])) {
                    totalQuant += 1;
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value 
                        = Convert.ToString(Convert.ToInt16(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value) + 1);
                    if (double.TryParse(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[5].Value.ToString(),
                        NumberStyles.Any, CultureInfo.InvariantCulture, out double valor1) &&
                        int.TryParse(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value.ToString(), out int valor2))
                    {
                        compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[6].Value = valor1 * valor2;
                    }
                }
                    
                else if (addCompra)
                    MessageBox.Show("Quantidade Indisponível no estoque!");

                else
                {
                    productQuant += 1;
                    totalQuant += 1;
                    compra_dataView.Rows.Add();
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[0].Value = compra_comboBox.Text;
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[1].Value = EstoqueData[compra_comboBox.Text]["Nome"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[2].Value = EstoqueData[compra_comboBox.Text]["Categoria"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[3].Value = EstoqueData[compra_comboBox.Text]["Setor"];

                    if (Convert.ToInt16(EstoqueData[compra_comboBox.Text]["Quant"]) > 0)
                    {
                        compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value = "1";
                    }

                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[5].Value = EstoqueData[compra_comboBox.Text]["Preco"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[6].Value = EstoqueData[compra_comboBox.Text]["Preco"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[7].Value = EstoqueData[compra_comboBox.Text]["Desc"];
                    compra_comboBox.Text = "";
                }
            }
            updateTelaDeCompra();
        }

        double CalcularValorFinal()
        {
            double total = 0;
            foreach (DataGridViewRow row in compra_dataView.Rows)
            {
                if (double.TryParse(row.Cells[5].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor) 
                    && int.TryParse(row.Cells[4].Value.ToString(), out int quantidade))
                {
                    total += valor * quantidade;
                }
            }

            if (compra_radio_cre.Checked)
            {
                total += (total * 0.02);
            }
            else if (compra_radio_deb.Checked)
            {
                total += (total * 0.01);
            }
            else if (compra_radio_din.Checked)
            {

            }
            else if (compra_radio_pix.Checked)
            {
                
            }
            return total;
        }

        private void updateTelaDeCompra()
        {
            compra_label_returnFinalPrice.Text = $"R$: {CalcularValorFinal():F2}";
            compra_label_returnQuantTotal.Text = totalQuant.ToString();
            compra_label_returnQuantPreduct.Text = productQuant.ToString();
        }

        private void EstoqueButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                if (e.ColumnIndex == 9){
                    EstoqueDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception){
                Console.WriteLine("Unable to delete row");
            }
            refreshAlerta();
        }
        
        private void EstoqueAddButon(object sender, EventArgs e)
        {
            returnListBuy.SelectedIndex = 4;
            tabControl1.SelectedIndex = 4;
            EstoqueAddIdCombobox.DataSource = new BindingSource(EstoqueData.Keys, null);
        }

        private void compra_dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9)
                {
                    totalQuant -= Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value);
                    productQuant -= 1;
                    compra_dataView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 8)
                {
                    int rowValue = Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (rowValue == 1)
                    {
                        compra_dataView.Rows.RemoveAt(e.RowIndex);
                        totalQuant -= 1;
                        productQuant -= 1;
                    }
                    else if (rowValue > 1)
                    {
                        rowValue--;
                        compra_dataView.Rows[e.RowIndex].Cells[4].Value = rowValue.ToString();
                        totalQuant -= 1;
                        if (double.TryParse(compra_dataView.Rows[e.RowIndex].Cells[5].Value.ToString(),
                        NumberStyles.Any, CultureInfo.InvariantCulture, out double valor1) &&
                        int.TryParse(compra_dataView.Rows[e.RowIndex].Cells[4].Value.ToString(), out int valor2))
                        {
                            compra_dataView.Rows[e.RowIndex].Cells[6].Value = valor1 * valor2;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Deu ruim");
            }
            updateTelaDeCompra();
        }

        public void EstoqueSaveButtonFunc(object sender, EventArgs e)
        {
            var estoqueAux = EstoqueData;

            estoqueAux = new Dictionary<string, Dictionary<string, string>>();
            foreach (DataGridViewRow row in EstoqueDataGrid.Rows)
            {
                string aux = (string)row.Cells[5].Value;
                row.Cells[5].Value = aux.Replace(",", ".");
                estoqueAux.Add((string)row.Cells[0].Value, new Dictionary<string, string>()
                {
                    {"Nome", (string)row.Cells[1].Value},
                    {"Categoria", (string)row.Cells[2].Value},
                    {"Setor", (string)row.Cells[3].Value},
                    {"Quant", (string)row.Cells[4].Value},
                    {"Preco", (string)row.Cells[5].Value},
                    {"Desc", (string)row.Cells[6].Value},
                    {"AlertaMin", (string)row.Cells[7].Value },
                    {"AlertaMax", (string)row.Cells[8].Value }
                });
            }
            compra_comboBox.DataSource = new BindingSource(EstoqueData, null);
            compra_comboBox.DisplayMember = "Key";

            if (currentEstoque == "EstoqueData")
                EstoqueData = estoqueAux;
            else if (currentEstoque == "EstoqueDataPendente")
                EstoqueDataPendente = estoqueAux;

            JsonFileData = JsonConvert.SerializeObject(estoqueAux);

            using (StreamWriter file = new StreamWriter($"{currentEstoque}.json"))
                file.WriteLine(JsonFileData);
        }

        private void compra_button_endbuy_Click(object sender, EventArgs e)

        {
            if (stateCompraRadioButton == false)
            {
                MessageBox.Show("Selecione uma forma de Pagamento", "Erro de Seleção");
            }
            else if (compra_dataView.Rows.Count < 1)
            {

                MessageBox.Show("Adicione um produto");
            }
            else
            {
                foreach (DataGridViewRow row in compra_dataView.Rows)
                {
                    int temp_quant = int.TryParse(row.Cells[4].Value?.ToString(), out int result) ? result : 0;

                    string temp_id = (string)row.Cells[0].Value; MessageBox.Show(temp_id);

                    EstoqueData[temp_id]["Quant"] = (Convert.ToInt16(EstoqueData[temp_id]["Quant"]) - temp_quant).ToString();
                }
                compra_label_returnFinalPrice.Text = $"R$: {0:F2}";
                RenerateBuyRegister();
                compra_dataView.Rows.Clear();
                reloadEstoque();
                EstoqueSaveButtonFunc(sender, e);
            }
            
        }

        void conferirEstoqueAtual()
        {
            if (EstoqueComboBox.Text == "Atual")
                currentEstoque = "EstoqueData";
            else if (EstoqueComboBox.Text == "Pendente")
                currentEstoque = "EstoqueDataPendente";
        }

        private void radioButtonClick(object sender, EventArgs e)
        {
            radioButton_click(sender, e);
            stateCompraRadioButton = true;
        }

        private void radioButton_click(object sender, EventArgs e)
        {
            if ((sender as RadioButton)?.Checked == true)
            {
                updateTelaDeCompra();
            }
        }

        private void RenerateBuyRegister()
        {
            try
            {
                try
                {
                    lastIdBuy = Convert.ToInt16(ComprasData.Keys.Last()) + 1;
                }
                catch
                {
                    lastIdBuy = 1;
                }

                Dictionary<string, Dictionary<string, object>> items = new Dictionary<string, Dictionary<string, object>>();

                foreach (DataGridViewRow row in compra_dataView.Rows)
                {

                    Dictionary<string, object> itemData = new Dictionary<string, object>();

                    var columnsToCheck = new List<string> { "minusButton", "removeButton" };
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string columnName = compra_dataView.Columns[cell.ColumnIndex].Name;
                        if (!columnsToCheck.Contains(columnName))
                        {
                            itemData[columnName] = cell.Value;
                        }
                    }

                    items.Add("Item" + row.Index, itemData);
                }

                lastIdBuy++;

                string payForm = "";
                if (compra_radio_cre.Checked)
                    payForm = "Credito";
                else if (compra_radio_deb.Checked)
                    payForm = "Debito";
                else if (compra_radio_din.Checked)
                    payForm = "Dinheiro";
                else if (compra_radio_pix.Checked)
                    payForm = "Pix";

                ComprasData[lastIdBuy.ToString()] = new Dictionary<string, object>
                {
                    { "Date" , compra_label_returnDayBuy.Text },
                    { "Time" , compra_returnTimeBuy.Text },
                    { "PayForm" , payForm },
                    { "Price" , compra_label_returnFinalPrice.Text },
                    { "TotalItems" , compra_label_returnQuantTotal.Text },
                    { "ProductQuant" , compra_label_returnQuantPreduct.Text.ToString() },
                    { "Items" , items }
                };

                string json = JsonConvert.SerializeObject(ComprasData, Formatting.Indented);
                File.WriteAllText("registerBuys.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o registro de compra: " + ex.Message);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchValue = EstoqueTextbox.Text;
            EstoqueDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in EstoqueDataGrid.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            EstoqueDataGrid.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + EstoqueTextbox.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void returnCompraData()
        {
            try
            {
                string caminhoArquivo = "registerBuys.json";
                if (File.Exists(caminhoArquivo))
                {
                    string jsonString = File.ReadAllText(caminhoArquivo);
                    ComprasData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(jsonString) ?? new Dictionary<string, Dictionary<string, object>>();
                }
                else
                {
                    ComprasData = new Dictionary<string, Dictionary<string, object>>();
                }
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show("Erro ao deserializar o JSON: " + jsonEx.Message);
                ComprasData = new Dictionary<string, Dictionary<string, object>>();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + ioEx.Message);
                ComprasData = new Dictionary<string, Dictionary<string, object>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
                ComprasData = new Dictionary<string, Dictionary<string, object>>();
            }
        }

        private void compra_button_cancelbuy_Click(object sender, EventArgs e)
        {
            compra_dataView.Rows.Clear();
            productQuant = 0;
            totalQuant = 0;
            updateTelaDeCompra();
        }

        private void EstoqueComboBox_TextUpdate(object sender, EventArgs e)
        {
            var aux = (sender as ComboBox);
            if (aux.Name == "EstoqueTypeComboBox")
                EstoqueComboBox.Text = aux.Text;
            else
                EstoqueTypeComboBox.Text = EstoqueComboBox.Text;
            conferirEstoqueAtual();
            reloadEstoque();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            returnListBuy.SelectedIndex = 2;
            limparCampos();
        }

        void limparCampos()
        { //uau
            EstoqueAddIdCombobox.Text = "";
            AddItemTextBox.Text = "";
            EstoqueAddCategoriaTextBox.Text = "";
            EstoqueAddSetorTextBox.Text = "";
            EstoqueAddQuantTextBox.Text = "";
            EstoqueAddPrecoTextBox.Text = "";
            EstoqueAddDescTextBox.Text = "";
            EstoqueAddMinTextBox.Text = "";
            EstoqueAddMaxTextBox.Text = "";
        }

        private void EstoqueAddSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                lastId = Convert.ToInt16(EstoqueComparativo.Keys.Last()) + 1;
            }
            catch
            {
                lastId = 1;
            }

            var estoqueOld = EstoqueData[EstoqueAddIdCombobox.Text];

            var estoqueAux = EstoqueData;
            if (currentEstoque == "EstoqueData")
                estoqueAux = EstoqueData;
            else if (currentEstoque == "EstoqueDataPendente")
                estoqueAux = EstoqueDataPendente;

            estoqueAux[EstoqueAddIdCombobox.Text] = new Dictionary<string, string>()
            {
                {"Nome",  AddItemTextBox.Text},
                {"Categoria",  EstoqueAddCategoriaTextBox.Text},
                {"Setor",  EstoqueAddSetorTextBox.Text},
                {"Quant",  EstoqueAddQuantTextBox.Text},
                {"Preco",  EstoqueAddPrecoTextBox.Text},
                {"Desc",  EstoqueAddDescTextBox.Text},
                {"AlertaMin",  EstoqueAddMinTextBox.Text},
                {"AlertaMax",  EstoqueAddMaxTextBox.Text},
            };

            EstoqueComparativo[lastId.ToString()] = new Dictionary<string, Dictionary<string, string>>();
            EstoqueComparativo[lastId.ToString()]["Antigo"] = estoqueOld;
            EstoqueComparativo[lastId.ToString()]["Novo"] = EstoqueData[EstoqueAddIdCombobox.Text];

            if (currentEstoque == "EstoqueData")
                EstoqueData = estoqueAux;
            else if (currentEstoque == "EstoqueDataPendente")
                EstoqueDataPendente = estoqueAux;

            string json = JsonConvert.SerializeObject(EstoqueComparativo, Formatting.Indented);
            File.WriteAllText("estoqueHistorico.json", json);

            reloadEstoque();
            EstoqueSaveButtonFunc(sender, e);
            limparCampos();
            refreshEstoqueHist();
            
            if ((sender as Button).Text == "Salvar e Sair")
                Cancelar(sender, e);
        }

        private void EstoqueAddIdCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string text = (sender as ComboBox).Text;
                AddItemTextBox.Text = EstoqueData[text]["Nome"];
                EstoqueAddCategoriaTextBox.Text = EstoqueData[text]["Categoria"];
                EstoqueAddSetorTextBox.Text = EstoqueData[text]["Setor"];
                EstoqueAddQuantTextBox.Text = EstoqueData[text]["Quant"];
                EstoqueAddPrecoTextBox.Text = EstoqueData[text]["Preco"];
                EstoqueAddDescTextBox.Text = EstoqueData[text]["Desc"];
                EstoqueAddMinTextBox.Text = EstoqueData[text]["AlertaMin"];
                EstoqueAddMaxTextBox.Text = EstoqueData[text]["AlertaMax"];
            }
            catch
            {
                MessageBox.Show("Erro ao ler Data do Produto");
            }
        }

        private void EstoqueHistPanel_Paint(object sender, PaintEventArgs e)
        {
            EstoqueHistPanel.AutoScroll = true;
            EstoqueHistPanel.HorizontalScroll.Maximum = 0;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AddItemTextBox.Text = "";
            EstoqueAddCategoriaTextBox.Text = "";
            EstoqueAddSetorTextBox.Text = "";
            EstoqueAddQuantTextBox.Text = "";
            EstoqueAddPrecoTextBox.Text = "";
            EstoqueAddDescTextBox.Text = "";
            EstoqueAddMinTextBox.Text = "";
            EstoqueAddMaxTextBox.Text = "";
        }
    
        private void GenerateHistoryBuysScreen()
        {
            List<string> keys = ComprasData.Keys.ToList();
            keys.Reverse();

            foreach (var item in keys)
            {
                try 
                { 
                    Histoty_dataGrid.Rows.Add();
                    Histoty_dataGrid.Rows[Histoty_dataGrid.Rows.Count - 1].Cells[0].Value = Convert.ToString(item);
                    Histoty_dataGrid.Rows[Histoty_dataGrid.Rows.Count - 1].Cells[1].Value = ComprasData[item]["Date"];
                    Histoty_dataGrid.Rows[Histoty_dataGrid.Rows.Count - 1].Cells[2].Value = ComprasData[item]["Time"];
                    Histoty_dataGrid.Rows[Histoty_dataGrid.Rows.Count - 1].Cells[3].Value = ComprasData[item]["Price"];
                    Histoty_dataGrid.Rows[Histoty_dataGrid.Rows.Count - 1].Cells[4].Value = ComprasData[item]["TotalItems"];
                }
                catch
                {
                    continue;
                }
            }
        }

        private void Histoty_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(e.RowIndex);

            listbuy_label_returnID.Text = Convert.ToString(Histoty_dataGrid.Rows[e.RowIndex].Cells[0].Value);
            listbuy_label_returnDate.Text = Convert.ToString(Histoty_dataGrid.Rows[e.RowIndex].Cells[1].Value);
            listbuy_label_returnTime.Text = Convert.ToString(Histoty_dataGrid.Rows[e.RowIndex].Cells[2].Value);
            listbuy_label_returnFinalPrice.Text = Convert.ToString(Histoty_dataGrid.Rows[e.RowIndex].Cells[3].Value);
            listbuy_label_returnTotal.Text = Convert.ToString(Histoty_dataGrid.Rows[e.RowIndex].Cells[4].Value);
            listbuy_label_returnProduts.Text = ComprasData[id]["ProductQuant"].ToString();
            listbuy_label_payment.Text = ComprasData[id]["PayForm"].ToString();

            if (ComprasData.TryGetValue("Items", out var items))
            {
                foreach (var itemKey in items.Keys)
                {
                    if (items[itemKey] is Dictionary<string, object> itemData)
                    {
                        try
                        {
                            listbuy_dataGrid.Rows.Add();
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[0].Value = itemData.ContainsKey("ID") ? itemData["ID"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[1].Value = itemData.ContainsKey("Nome") ? itemData["Nome"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[2].Value = itemData.ContainsKey("Categoria") ? itemData["Categoria"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[3].Value = itemData.ContainsKey("Setor") ? itemData["Setor"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[4].Value = itemData.ContainsKey("Quantidade") ? itemData["Quantidade"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[5].Value = itemData.ContainsKey("PrecoUni") ? itemData["PrecoUni"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[6].Value = itemData.ContainsKey("total") ? itemData["total"].ToString() : string.Empty;
                            listbuy_dataGrid.Rows[listbuy_dataGrid.Rows.Count - 1].Cells[7].Value = itemData.ContainsKey("Desc") ? itemData["Desc"].ToString() : string.Empty;
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }

            returnListBuy.SelectedIndex = 5;
        }

        private void listbuy_button_close_Click(object sender, EventArgs e)
        {
            returnListBuy.SelectedIndex = 1;
        }
    }
}