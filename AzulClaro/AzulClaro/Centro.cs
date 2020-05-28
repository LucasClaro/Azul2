using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Centro
    {
        public List<Azulejo> azulejos { get; set; }
        public bool marca1 { get; set; }

        public Point[] organizarEmLinhas()
        {
            int qtdAzul = 0, qtdlinhas, camadaValencia;
            int BaseX = 175, BaseY = 275;
            int PosX, PosY;
            Point[] points = new Point[30];
            int w = 0;

            foreach (Azulejo azulejo in this.azulejos)
            {
                qtdAzul += azulejo.quantidade;
            } 

            qtdlinhas = qtdAzul / 6;
            camadaValencia = qtdAzul % 6;

            for (int l = 0; l < qtdlinhas; l++)
            {
                for (int a = 0; a < 6; a++)
                {
                    PosX = BaseX + (55 * a);
                    PosY = BaseY + (55 * l);

                    Point point = new Point(PosX, PosY);
                    points[w] = point;

                    w++;
                }
            }

            BaseX += 25 * (6 - camadaValencia) + 5 * ((6 - camadaValencia) / 2);

            for (int i = 0; i < camadaValencia; i++)
            {
                PosX = BaseX + (55 * i);
                if (qtdlinhas >= 4)
                {
                    PosY = BaseY - 55;
                }
                else
                {
                    PosY = BaseY + (55 * (qtdlinhas));
                }                

                Point point = new Point(PosX, PosY);
                points[w] = point;

                w++;
            }

            return points;
        }

        public int qtdCentro()
        {
            int x = 0;

            foreach (Azulejo azulejo in this.azulejos)
            {
                if (azulejo.quantidade > 0)
                {
                    x++;
                }
            }

            return x;
        }
    }
}