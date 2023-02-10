using System;
using System.Reflection;
using System.Xml.Linq;
using static laboratorySix.Mobile;


namespace laboratorySix
{
    class IBM
    {
        public IBM(string MacAddress, string LocalIP, string Version)
        {
            macAdress = MacAddress;
            localIP = LocalIP;
            version = Version;
        }
        public IBM()
        {
            macAdress = "nothing";
            localIP = "";
            version = "0";

        }

        string macAdress, localIP, version;
        public virtual string FullNameDevice
        {
            get { return "Характеристики: " + macAdress + " | " + localIP + " | " + version; }
        }
    }


    class Mobile : IBM
    {
        string device, model, name, lastname;
        public Mobile(string MacAddress, string LocalIP, string Version, string Devices, string Model, string Name, string LastName) : base(MacAddress, LocalIP, Version)
        {
            device = Devices;
            model = Model;
            name = Name;
            lastname = LastName;

        }
        public Mobile()
        {
            name = "UndeFined";
            lastname = "UndeFined";
            device = " ";
            model = " ";

        }
        public override string FullNameDevice
        {
            get { return base.FullNameDevice + " | " + device + " | " + model + " |  Владелец: " + name + " " + lastname; }
        }
        public enum CompanyOfLaptop
        {
            Apple,
            Samsung,
            Lenovo,
            Houwei,
            Honor,
        }
        public enum CompanyOfTablet
        {
            Apple,
            Samsung,
            Lenovo,
            Houwei,

        }
        class Computer : IBM
        {
            string VideoCard, proccessor, mothPlate, blockPower, Culler, memoryHDD, memorySSD;
            public Computer(string MacAddress, string LocalIP, string Version, string VideoCard, string proccessor, string mothPlate, string blockPower, string Culler, string memoryHDD, string memorySSD) : base(MacAddress, LocalIP, Version)
            {
                this.proccessor = proccessor;
                this.VideoCard = VideoCard;
                this.blockPower = blockPower;
                this.Culler = Culler;
                this.memoryHDD = memoryHDD;
                this.memorySSD = memorySSD;
                this.mothPlate = mothPlate;
            }
            public Computer()
            {
                VideoCard = "Noname";
                proccessor = "Noname";
                mothPlate = "Noname";
                blockPower = "Noname";
                Culler = "Noname";
                memoryHDD = "Noname";
                memorySSD = "NoName";
            }
            public override string FullNameDevice
            {
                get { return base.FullNameDevice + " | " + VideoCard + " | " + proccessor + " | " + mothPlate + " | " + memoryHDD + " | " + memorySSD + " | " + blockPower; }
            }
        }
        class Tablet : Mobile
        {
            string power, screen;
            CompanyOfTablet companyTablet;
            public Tablet(string MacAddress, string LocalIP, string Version, string Devices, string Model, string Name, string LastName, string Power, string screen, CompanyOfTablet companyTablet) : base(MacAddress, LocalIP, Version, Devices, Model, Name, LastName)
            {
                power = Power;
                this.screen = screen;
                this.companyTablet = companyTablet;
            }
            public override string FullNameDevice
            {
                get { return base.FullNameDevice + " | " + "Devices of Tablet : " + " | " + companyTablet.ToString() + " | " + screen; }
            }


        }
        class Laptop : Mobile
        {
            string videocard;
            CompanyOfLaptop companyLapTop;
            public Laptop(string MacAddress, string LocalIP, string Version, string Devices, string Model, string Name, string LastName, string VideoCard, CompanyOfLaptop companyOfLaptop) : base(MacAddress, LocalIP, Version, Devices, Model, Name, LastName)
            {
                videocard = VideoCard;
                this.companyLapTop = companyLapTop;
            }
            public override string FullNameDevice
            {
                get { return base.FullNameDevice + " | " + "Devices of Laptop : " + " | " + companyLapTop.ToString() + " | " + videocard;}
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                IBM[] mas = new IBM[5];
                mas[0] = new IBM("001A3FF14CC6", "192.168.0.1", "1.0");
                mas[1] = new Mobile("F02A3FF14CC6", "192.168.0.2", "2.0", "Phone", "X", "Nikita", "Musatov");
                mas[2] = new Computer("152A312F14CC6", "192.168.0.3", "v15.32c", "NVideaRTX4090", "Intel", "AsusPro_450M","AeroCool600W", "AeroCool_ZNX","samsung1TB","clucial512gb");
                mas[3] = new Tablet("CA2A3FF16CC6", "192.168.0.4", "5.0", "Tablet", "Air", "Nikita", "Musatov", "5000mHa", "15.6dm", CompanyOfTablet.Apple);
                mas[4] = new Laptop("SEXA3FF14C15", "192.168.0.5", "18.0", "Laptop", "DeepGameX", "Nikita", "Musatov", "IntelHDGrafics",CompanyOfLaptop.Lenovo);
                Console.WriteLine(">>>>>>>>>>>>>>>>BY_NIKITA<<<<<<<<<<<<");
                Console.WriteLine();
                for (int i = 0; i < mas.Length;i++)
                {
                    Console.WriteLine(">>>>>>>" + mas[i].GetType().Name);
                    Console.WriteLine(mas[i].FullNameDevice);
                    Console.WriteLine();

                }

            }
        }
    }
}