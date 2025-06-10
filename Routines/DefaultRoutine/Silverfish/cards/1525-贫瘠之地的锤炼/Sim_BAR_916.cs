using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_916 : SimTemplate //* 血之碎片刺背野猪人 Blood Shard Bristleback
	{
        //[x]<b>Lifesteal</b>. <b>Battlecry:</b> If yourdeck contains 10 or fewercards, deal 6 damageto a minion.
        //<b>吸血</b>，<b>战吼：</b>如果你的牌库少于或等于10张，对一个随从造成6点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;
            int dmg = 6;
            p.minionGetDamageOrHeal(target, dmg);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }



    }
}
