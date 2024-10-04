using System;
using System.Reflection;

namespace _10._7_hw_List
{
    public partial class Form1 : Form
    {
        Country[] countries;
        public Form1()
        {
            InitializeComponent();
            House[] homes = { new House(1), new House(2) };
            countries = new Country[]
            {
                new Country("������", new City[]
                {
                    new City("������", new Street[]
                    {
                        new Street("����� �����", homes),
                        new Street("������������", homes)
                    }),
                    new City("��������", new Street[]
                    {
                        new Street("��. ��������� ���������", homes),
                        new Street("�������������", homes)
                    })
                }),
                new Country("���", new City[]
                {
                    new City("���-����", new Street[]
                    {
                        new Street("����� �����", homes),
                        new Street("����-�����", new House[]{new House(3), new House(4)})
                    }),
                    new City("���������", new Street[]
                    {
                        new Street("������������-�����", homes),
                        new Street("���� �����", homes)
                    })
                })
            };
            foreach (Country country in countries)
            {
                comboBoxCountry.Items.Add(country.Name);
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();
            comboBoxCity.Enabled = false;
            comboBoxStreet.Items.Clear();
            comboBoxStreet.Enabled = false;
            comboBoxHouse.Items.Clear();
            comboBoxHouse.Enabled = false;

            if (comboBoxCountry.SelectedIndex == 0)
            {
                for (int i = 0; i < countries[0].cities.Length; i++)
                {
                    comboBoxCity.Items.Add(countries[0].cities[i].Name);

                }
            }
            else
            {
                for (int i = 0; i < countries[0].cities.Length; i++)
                {
                    comboBoxCity.Items.Add(countries[1].cities[i].Name);

                }
            }

            comboBoxCity.Enabled = true;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStreet.Items.Clear();
            comboBoxHouse.Items.Clear();
            comboBoxStreet.Enabled = false;
            comboBoxHouse.Enabled = false;
            for (int j = 0; j < countries[comboBoxCountry.SelectedIndex].cities[comboBoxCity.SelectedIndex].streets.Length; j++)
            {
                comboBoxStreet.Items.Add(countries[comboBoxCountry.SelectedIndex].cities[comboBoxCity.SelectedIndex].streets[j].Name);
            }
            comboBoxStreet.Enabled = true;
        }

        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHouse.Items.Clear();
            comboBoxHouse.Enabled = false;
            for (int k = 0; k < countries[comboBoxCountry.SelectedIndex].cities[comboBoxCity.SelectedIndex].streets[comboBoxStreet.SelectedIndex].homes.Length; k++)
            {
                comboBoxHouse.Items.Add(countries[comboBoxCountry.SelectedIndex].cities[comboBoxCity.SelectedIndex].streets[comboBoxStreet.SelectedIndex].homes[k].Id);
            }
            comboBoxHouse.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
