using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_064 : SimTemplate //* 小型法术蓝宝石 Lesser Sapphire Spellstone
//Summon 1 copy of a friendly minion. @<i>(<b>Overload</b> 3 Mana Crystals to upgrade.)</i>
//选择一个友方随从，召唤一个它的复制。@<i>（<b>过载</b>三个法力水晶后升级。）</i> 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            int pos = temp.Count;
            if (pos < 7)
            {
                p.callKid(target.handcard.card, pos, ownplay);
                temp[pos].setMinionToMinion(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}