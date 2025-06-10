using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Mekka4 : SimTemplate //* 变鸡器 Poultryizer
//At the start of your turn, transform a random minion into a 1/1 Chicken.
//在你的回合开始时，随机将一个随从变为1/1的小鸡。 
	{
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.Mekka4t);
                                


        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                Minion tm = null;
                int ges = 1000;
                foreach (Minion m in p.ownMinions)
                {
                    if (m.Angr + m.Hp < ges)
                    {
                        tm = m;
                        ges = m.Angr + m.Hp;
                    }
                }
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.Angr + m.Hp < ges)
                    {
                        tm = m;
                        ges = m.Angr + m.Hp;
                    }
                }
                if (ges <= 999)
                {
                    p.minionTransform(tm, c);
                    tm.playedThisTurn = false;
                    tm.Ready = true;
                }
            }
        }

      

	}
}