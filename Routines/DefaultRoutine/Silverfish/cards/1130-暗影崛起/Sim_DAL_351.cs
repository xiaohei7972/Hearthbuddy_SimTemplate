using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_351 : SimTemplate //* 远古祝福 Blessing of the Ancients
//<b>Twinspell</b>Give your minions +1/+1.
//<b>双生法术</b>使你的所有随从获得+1/+1。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			p.drawACard(CardDB.cardIDEnum.DAL_351ts, ownplay, true);
			if (p.ownMinions.Count < 3) p.evaluatePenality += 30;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}