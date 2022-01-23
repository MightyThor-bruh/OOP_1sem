using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public interface ICaptain : IHelm
    {
        void Steer();
    }

    public interface IHelm
    {
        void Wheel();
    }

    public interface IWarship : IHelm
    {
        void Shoot();
        void ToSit();
    }
}
