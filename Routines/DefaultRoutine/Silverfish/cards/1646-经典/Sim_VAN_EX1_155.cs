using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_155 : SimTemplate //* 自然印记 Mark of Nature
	{
		//<b>Choose One -</b> Give a minion +4 Attack; or +4 Health and <b>Taunt</b>.
		//<b>抉择：</b>使一个随从获得+4攻击力；或者+4生命值和<b>嘲讽</b>。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.minionGetBuffed(target, 4, 0);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.minionGetBuffed(target, 0, 4);
                if (!target.taunt)
                {
                    target.taunt = true;
                    if (target.own) p.anzOwnTaunt++;
                    else p.anzEnemyTaunt++;
                }
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}