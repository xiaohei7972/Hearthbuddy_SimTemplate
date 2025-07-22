using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：4 生命值：6
	//Carnivorous Cube
	//食肉魔块
	//<b>Battlecry:</b> Destroya friendly minion.<b>Deathrattle:</b> Summon 2 copies of it.
	//<b>战吼：</b>消灭一个友方随从。<b>亡语：</b>召唤两个被消灭随从的复制。
	class Sim_LOOT_161_Puzzle : SimTemplate
	{
		// CardDB.Card kid = null;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
			{
				p.minionGetDestroyed(target);
                own.deathrattle2 = target.handcard.card;
			}
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.deathrattle2 != null)
            {
                int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(m.deathrattle2, pos, true);
                p.callKid(m.deathrattle2, pos, true);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE) // 没有目标时也可以使用

			};

        }
		
	}
}
