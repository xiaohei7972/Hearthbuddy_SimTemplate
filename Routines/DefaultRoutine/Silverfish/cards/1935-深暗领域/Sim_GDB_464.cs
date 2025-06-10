using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：0
	//Gravity Lapse
	//引力失效
	//Set EVERY minion's Attack and Health to the lower of the two.
	//将每个随从的攻击力和生命值变为两者中的低值。
	class Sim_GDB_464 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)//判断我方场面
            {
                if (m.Angr > m.Hp){
                    p.minionSetAngrToX(m, m.Hp);//如果随从攻击力＞生命值，将攻击力置为生命值的数值
                }else{
                    p.minionSetLifetoX(m, m.Angr);//如果随从攻击力<=生命值，将置生命值为攻击力的数值
                }
            }
            foreach (Minion m in p.enemyMinions)//判断敌方场面
            {
                if (m.Angr > m.Hp){
                    p.minionSetAngrToX(m, m.Hp);//如果随从攻击力＞生命值，将攻击力置为生命值的数值
                }else{
                    p.minionSetLifetoX(m, m.Angr);//如果随从攻击力<=生命值，将置生命值为攻击力的数值
                }
            }
        }
	}
}
