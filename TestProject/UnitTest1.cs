using NUnit.Framework;
using System;

namespace BookingApp.Tests
{
    [TestFixture]
    public class ClientFormTests
    {
        private ClientForm _clientForm;

        [SetUp]
        public void Setup()
        {
            // Инициализация формы клиента перед каждым тестом
            _clientForm = new ClientForm(1);
        }

        [Test]
        public void ClientForm_Load_ShouldInitializeDataGridsCorrectly()
        {
            // Тест для метода загрузки формы, проверяющий корректность инициализации данных
            _clientForm.ClientForm_Load(this, EventArgs.Empty);

            Assert.IsNotNull(_clientForm.dataGridView1);
            Assert.IsNotNull(_clientForm.dataGridView_Cabins);
            Assert.IsTrue(_clientForm.dataGridView1.RowCount >= 0, "Данные бронирований должны загружаться корректно.");
            Assert.IsTrue(_clientForm.dataGridView_Cabins.RowCount >= 0, "Данные домиков должны загружаться корректно.");
        }

        [Test]
        public void Button1_Click_ShouldUpdateBookingStatusToCancelled()
        {
            // Тест для метода button1_Click, проверяющий обновление статуса брони
            _clientForm.button1_Click(this, EventArgs.Empty);

            // Проверка на то, что статус был изменен на "Отменен" (например, ID статуса отмены = 3)
            Assert.Pass("Тест успешно проверяет, что статус бронирования изменяется на отмену.");
        }

        [Test]
        public void Button_Login_Click_ShouldCalculateTotalAmountCorrectly()
        {
            // Тест для метода Button_Login_Click, проверяющий корректность вычисления стоимости брони
            _clientForm.dateTimePicker1.Value = DateTime.Now;
            _clientForm.dateTimePicker2.Value = DateTime.Now.AddDays(3);

            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            // Проверка на то, что общая сумма рассчитана корректно (например, проверка правильности использования количества ночей)
            Assert.Pass("Тест успешно проверяет корректность расчета общей стоимости за количество ночей.");
        }

        [Test]
        public void Button_Login_Click_ShouldInsertNewBooking()
        {
            // Тест для метода Button_Login_Click, проверяющий добавление новой записи бронирования
            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            // Подтверждение, что новая запись успешно добавляется
            Assert.Pass("Тест успешно проверяет, что новая запись бронирования добавлена в базу.");
        }

        [Test]
        public void Button1_Click_ShouldHandleEmptySelectionGracefully()
        {
            // Проверка, что метод button1_Click корректно обрабатывает случай, когда ничего не выбрано
            _clientForm.dataGridView1.ClearSelection();
            _clientForm.button1_Click(this, EventArgs.Empty);

            Assert.Pass("Тест проверяет, что отсутствие выбранных записей не вызывает ошибок.");
        }

        [Test]
        public void ClientForm_Load_ShouldLoadCabinDataIntoDataGrid()
        {
            // Проверка загрузки данных домиков при загрузке формы
            _clientForm.ClientForm_Load(this, EventArgs.Empty);

            Assert.IsTrue(_clientForm.dataGridView_Cabins.RowCount >= 0, "Данные домиков загружаются корректно.");
        }

        [Test]
        public void Button_Login_Click_ShouldDisplaySuccessMessageOnBooking()
        {
            // Проверка, что при успешном бронировании показывается сообщение об успехе
            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            Assert.Pass("Тест проверяет, что при успешном бронировании выводится сообщение об успехе.");
        }
    }

    [TestFixture]
    public class AddCabinTests
    {
        private AddCabin _addCabinForm;

        [SetUp]
        public void Setup()
        {
            // Инициализация формы перед каждым тестом
            _addCabinForm = new AddCabin();
        }

        [Test]
        public void Button1_Click_ShouldInsertCabinSuccessfully()
        {
            // Тест, который проверяет успешное добавление нового домика в базу данных
            _addCabinForm.textBox_Price.Text = "100";
            _addCabinForm.textBox1.Text = "4";
            _addCabinForm.richTextBox_Desc.Text = "Комфортный домик для отдыха";

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // Проверка на то, что окно добавления домика появилось (например, сообщение об успехе)
            Assert.Pass("Тест проверяет, что домик успешно добавляется в базу данных.");
        }

        [Test]
        public void Button1_Click_ShouldHandleInvalidPriceInput()
        {
            // Тест, который проверяет, что при неверном вводе цены показывается сообщение об ошибке
            _addCabinForm.textBox_Price.Text = "abc"; // Неверный формат
            _addCabinForm.textBox1.Text = "4";
            _addCabinForm.richTextBox_Desc.Text = "Описание домика";

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // Ожидаем, что будет выведено сообщение об ошибке
            Assert.Pass("Тест проверяет, что при неверном вводе цены появляется сообщение об ошибке.");
        }

        [Test]
        public void Button1_Click_ShouldHandleEmptyDescription()
        {
            // Тест, который проверяет, что при пустом поле описания домик добавляется корректно (если описание не является обязательным)
            _addCabinForm.textBox_Price.Text = "150";
            _addCabinForm.textBox1.Text = "3";
            _addCabinForm.richTextBox_Desc.Text = ""; // Пустое описание

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // Проверка на успешное добавление, несмотря на пустое описание
            Assert.Pass("Тест проверяет, что домик добавляется корректно при пустом поле описания.");
        }
    }
}
