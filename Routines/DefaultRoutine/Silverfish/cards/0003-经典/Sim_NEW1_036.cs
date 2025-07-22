using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_036 : SimTemplate //* 命令怒吼 Commanding Shout
	{
		//Your minions can't be reduced below 1 Health this turn. Draw a card.
		//在本回合中，你的随从的生命值无法被降到1点以下。抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion t in temp)
            {
                t.cantLowerHPbelowONE = true;
            }
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }
}
