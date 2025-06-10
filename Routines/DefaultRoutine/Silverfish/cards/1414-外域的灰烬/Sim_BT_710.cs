using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_710 : SimTemplate //* 暗心贤者 Greyheart Sage
	{
        //[x]<b>Battlecry:</b> If you controla <b><b>Stealth</b>ed</b> minion,draw 2 cards.
        //<b>战吼：</b>如果你控制一个<b>潜行</b>的随从，抽两张牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                if (m.stealth)
                {
                    p.drawACard(CardDB.cardNameEN.armorplating, own.own);
                    p.drawACard(CardDB.cardNameEN.armorplating, own.own);
                    return;
                }
                else p.evaluatePenality += 50;
            }    
        }
    }
}
