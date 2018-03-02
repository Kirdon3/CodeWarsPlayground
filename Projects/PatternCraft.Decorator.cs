using System;
using Xunit;

namespace FirstBatch.kyu6
{
    public class DecoratorTests
    {
        [Fact]
        public void Test1()
        {
            IMarine marine = new Marine(10, 1);

            Assert.Equal(11, new MarineWeaponUpgrade(marine).Damage);
            Assert.Equal(11, new MarineWeaponUpgrade(marine).Damage);
        }

        [Fact]
        public void Test2()
        {
            IMarine marine = new Marine(15, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.Equal(17, marine.Damage);
        }

        [Fact]
        public void Test3()
        {
            IMarine marine = new Marine(20, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.Equal(23, marine.Damage);
        }
    }


    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineDecorator : IMarine
    {
        protected IMarine marine;

        public MarineDecorator(IMarine marine)
        {
            this.marine = marine;
        }

        public virtual int Damage
        {
            get => marine.Damage;
            set => marine.Damage = value;
        }

        public virtual int Armor
        {
            get => marine.Armor;
            set => marine.Armor = value;
        }
    }

    public class MarineWeaponUpgrade : MarineDecorator
    {

        public MarineWeaponUpgrade(IMarine marine) : base(marine)
        {
            this.marine = marine;
        }

        public override int Damage => marine.Damage + 1;
    }

    public class MarineArmorUpgrade : MarineDecorator
    {

        public MarineArmorUpgrade(IMarine marine) :base(marine)
        {
           
        }

        public override int Armor => marine.Armor + 1;
    }
}