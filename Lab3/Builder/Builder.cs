using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Builder
    {
        abstract class PCBuilder
        {
            public PC pc;
            public void CreatePC()
            {
                pc = new PC();
            }

            public abstract void SetMother();
            public abstract void SetCPU();
            public abstract void SetGPU();
        }

        class Worker
        {
            public PC CreatePC(PCBuilder pcBuilder)
            {

                pcBuilder.CreatePC();
                pcBuilder.SetMother();
                pcBuilder.SetCPU();
                pcBuilder.SetGPU();
                return pcBuilder.pc;
            }
        }


        class FirstPcBuilder : PCBuilder
        {
            public override void SetCPU()
            {
                this.pc.cpu = new CPU { Name = "1" };
            }

            public override void SetGPU()
            {
                this.pc.card = new GraphicsCard { Name = "1" };
            }

            public override void SetMother()
            {
                this.pc.board = new MotherBoard { Name = "1" };
            }
        }

        class SecondPcBuilder : PCBuilder
        {
            public override void SetCPU()
            {
                this.pc.cpu = new CPU { Name = "2" };
            }

            public override void SetGPU()
            {
                this.pc.card = new GraphicsCard { Name = "2" };
            }

            public override void SetMother()
            {
                this.pc.board = new MotherBoard { Name = "2" };
            }
        }

        class MotherBoard
        {
            public string Name { get; set; }
        }

        class GraphicsCard
        {
            public string Name { get; set; }
        }

        class CPU
        {
            public string Name { get; set; }
        }

        class PC
        {
            public MotherBoard board;
            public GraphicsCard card;
            public CPU cpu;
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (board != null)
                    sb.Append(board.Name + "\n");
                if (card != null)
                    sb.Append(card.Name + "\n");
                if (cpu != null)
                    sb.Append(cpu.Name + "\n");
                return sb.ToString();
            }
        }
    }
}
