using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_159 : SimTemplate //* 裂心者伊露希亚 Mindrender Illucia
	{
        //<b>Battlecry:</b> Swap hands and decks with your opponent until your next turn.
        //<b>战吼：</b>直到你的下个回合，和你的对手交换手牌和牌库。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.card.nameCN == CardDB.cardNameCN.心灵震爆)
                {
                    p.minionGetDamageOrHeal(p.ownHero, 5);
                }
            }
            p.owncards = new List<Handmanager.Handcard>();
        }

    }
}
