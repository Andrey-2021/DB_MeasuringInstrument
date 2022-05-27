using System.ComponentModel;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Класс содержит общие методы для работы с данными (Экземплярами классов предметной области)
    /// </summary>
    [DesignTimeVisible(false)]
    [DesignerCategory("Form")]
    public class BaseViewForDbForms : BaseViewShowErrorAndWarning
    {
        public void OnAdding(object sender, EventHandler? Adding)
        {
            if (Adding != null)
            {
                Adding(sender, EventArgs.Empty);
            }
            else
            {
                ShowError("В программе нет возможности добавить новые данные в БД!");
            }
        }

        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо обновить данные в БД
        /// </summary>
        public void OnEditing<T>(object sender, EventHandler<T>? Editing, T data) where T : class
        {
            if (Editing != null)
            {
                Editing(sender, data);
            }
            else
            {
                ShowError("В программе нет возможности обновить данные в БД!");
            }
        }

        public void OnDeleting<T>(object sender, EventHandler<T>? Deleting, T data)
        {
            if (Deleting != null)
            {
                Deleting(sender, data);
            }
            else
            {
                ShowError("В программе нет возможности удалить данные из БД!");
            }
        }

        public void OnRefreshAll(object sender, EventHandler? RefreshAll)
        {
            if (RefreshAll != null)
            {
                RefreshAll(sender, EventArgs.Empty);
            }
            else
            {
                ShowError("В программе нет возможности обновить данные из БД!");
            }
        }

        /// <summary>
        /// Настройка DataGridView
        /// </summary>
        /// <param name="dataGridView"></param>
        public void IntitDatGridView(DataGridView dataGridView)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            dataGridView.AutoResizeColumns();
            dataGridView.ReadOnly = true;
        }

        /// <summary>
        /// Получить выбранные данные
        /// </summary>
        /// <returns></returns>
        public T? GetDataFromSelectedRow<T>(DataGridView dataGridView) where T : class
        {
            if (dataGridView.SelectedCells.Count <= 0)
            {
                ShowWarning("Нет выбранных данных!");
                return default(T);
            }

            var data = dataGridView.SelectedRows[0].DataBoundItem
                as T;

            if (data == null) return default(T);
            else return data;
        }

        /// <summary>
        /// Выделение строки (установка курсора) в DataGridView, содержащей объект entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="entity"></param>
        public void SelectRowInDataGrid<T>(DataGridView dataGridView, T? entity) where T : class
        {
            //Курсор ставим на новую добавленну строчку
            if (entity != null)
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    var row = dataGridView.Rows[i];
                    T? record = row.DataBoundItem as T;
                    if (record != null)
                    {
                        if (record.Equals(entity))
                        {
                            dataGridView.CurrentCell = dataGridView[0, i];//перемещаем курсор
                            dataGridView.Rows[i].Selected = true; //выделяем строчку
                            break;
                        }
                    }
                }
            }
        }
    }
}
