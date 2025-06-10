using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_328 : SimTemplate //* 竞技推广员 Fight Promoter
//[x]<b>Battlecry:</b> If you controla minion with 6 or more_Health, draw two cards.
//<b>战吼：</b>如果你控制一个生命值大于或等于6的随从，抽两张牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.Hp >= 6)
                {
                    p.drawACard(CardDB.cardIDEnum.None, m.own);
                    p.drawACard(CardDB.cardIDEnum.None, m.own);
                    break;
                }
            }
        }
    }
}