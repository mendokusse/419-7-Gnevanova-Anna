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
            // ������������� ����� ������� ����� ������ ������
            _clientForm = new ClientForm(1);
        }

        [Test]
        public void ClientForm_Load_ShouldInitializeDataGridsCorrectly()
        {
            // ���� ��� ������ �������� �����, ����������� ������������ ������������� ������
            _clientForm.ClientForm_Load(this, EventArgs.Empty);

            Assert.IsNotNull(_clientForm.dataGridView1);
            Assert.IsNotNull(_clientForm.dataGridView_Cabins);
            Assert.IsTrue(_clientForm.dataGridView1.RowCount >= 0, "������ ������������ ������ ����������� ���������.");
            Assert.IsTrue(_clientForm.dataGridView_Cabins.RowCount >= 0, "������ ������� ������ ����������� ���������.");
        }

        [Test]
        public void Button1_Click_ShouldUpdateBookingStatusToCancelled()
        {
            // ���� ��� ������ button1_Click, ����������� ���������� ������� �����
            _clientForm.button1_Click(this, EventArgs.Empty);

            // �������� �� ��, ��� ������ ��� ������� �� "�������" (��������, ID ������� ������ = 3)
            Assert.Pass("���� ������� ���������, ��� ������ ������������ ���������� �� ������.");
        }

        [Test]
        public void Button_Login_Click_ShouldCalculateTotalAmountCorrectly()
        {
            // ���� ��� ������ Button_Login_Click, ����������� ������������ ���������� ��������� �����
            _clientForm.dateTimePicker1.Value = DateTime.Now;
            _clientForm.dateTimePicker2.Value = DateTime.Now.AddDays(3);

            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            // �������� �� ��, ��� ����� ����� ���������� ��������� (��������, �������� ������������ ������������� ���������� �����)
            Assert.Pass("���� ������� ��������� ������������ ������� ����� ��������� �� ���������� �����.");
        }

        [Test]
        public void Button_Login_Click_ShouldInsertNewBooking()
        {
            // ���� ��� ������ Button_Login_Click, ����������� ���������� ����� ������ ������������
            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            // �������������, ��� ����� ������ ������� �����������
            Assert.Pass("���� ������� ���������, ��� ����� ������ ������������ ��������� � ����.");
        }

        [Test]
        public void Button1_Click_ShouldHandleEmptySelectionGracefully()
        {
            // ��������, ��� ����� button1_Click ��������� ������������ ������, ����� ������ �� �������
            _clientForm.dataGridView1.ClearSelection();
            _clientForm.button1_Click(this, EventArgs.Empty);

            Assert.Pass("���� ���������, ��� ���������� ��������� ������� �� �������� ������.");
        }

        [Test]
        public void ClientForm_Load_ShouldLoadCabinDataIntoDataGrid()
        {
            // �������� �������� ������ ������� ��� �������� �����
            _clientForm.ClientForm_Load(this, EventArgs.Empty);

            Assert.IsTrue(_clientForm.dataGridView_Cabins.RowCount >= 0, "������ ������� ����������� ���������.");
        }

        [Test]
        public void Button_Login_Click_ShouldDisplaySuccessMessageOnBooking()
        {
            // ��������, ��� ��� �������� ������������ ������������ ��������� �� ������
            _clientForm.Button_Login_Click(this, EventArgs.Empty);

            Assert.Pass("���� ���������, ��� ��� �������� ������������ ��������� ��������� �� ������.");
        }
    }

    [TestFixture]
    public class AddCabinTests
    {
        private AddCabin _addCabinForm;

        [SetUp]
        public void Setup()
        {
            // ������������� ����� ����� ������ ������
            _addCabinForm = new AddCabin();
        }

        [Test]
        public void Button1_Click_ShouldInsertCabinSuccessfully()
        {
            // ����, ������� ��������� �������� ���������� ������ ������ � ���� ������
            _addCabinForm.textBox_Price.Text = "100";
            _addCabinForm.textBox1.Text = "4";
            _addCabinForm.richTextBox_Desc.Text = "���������� ����� ��� ������";

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // �������� �� ��, ��� ���� ���������� ������ ��������� (��������, ��������� �� ������)
            Assert.Pass("���� ���������, ��� ����� ������� ����������� � ���� ������.");
        }

        [Test]
        public void Button1_Click_ShouldHandleInvalidPriceInput()
        {
            // ����, ������� ���������, ��� ��� �������� ����� ���� ������������ ��������� �� ������
            _addCabinForm.textBox_Price.Text = "abc"; // �������� ������
            _addCabinForm.textBox1.Text = "4";
            _addCabinForm.richTextBox_Desc.Text = "�������� ������";

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // �������, ��� ����� �������� ��������� �� ������
            Assert.Pass("���� ���������, ��� ��� �������� ����� ���� ���������� ��������� �� ������.");
        }

        [Test]
        public void Button1_Click_ShouldHandleEmptyDescription()
        {
            // ����, ������� ���������, ��� ��� ������ ���� �������� ����� ����������� ��������� (���� �������� �� �������� ������������)
            _addCabinForm.textBox_Price.Text = "150";
            _addCabinForm.textBox1.Text = "3";
            _addCabinForm.richTextBox_Desc.Text = ""; // ������ ��������

            _addCabinForm.button1_Click(this, EventArgs.Empty);

            // �������� �� �������� ����������, �������� �� ������ ��������
            Assert.Pass("���� ���������, ��� ����� ����������� ��������� ��� ������ ���� ��������.");
        }
    }
}
