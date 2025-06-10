using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_324 : SimTemplate //* 重金属狂潮 Heavy Metal!
//[x]Summon a randomminion with Cost equalto your Armor <i>(up to 10).</i>
//随机召唤一个法力值消耗等同于你的护甲值<i>（最高不超过10点）</i>的随从。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.icehowl), pos, ownplay, false);
            else p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.frostgiant), pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}