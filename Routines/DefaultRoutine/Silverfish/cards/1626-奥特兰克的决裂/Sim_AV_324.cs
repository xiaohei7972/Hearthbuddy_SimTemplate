using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_324 : SimTemplate //* 暗言术噬 shadowworddevour
	{
		//选择一个随从，使其从所有其他随从处各偷取1点生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int i = 0;
            foreach (Minion m in p.ownMinions)
            {
                if (m != target && !m.untouchable)
                {
                    p.minionGetBuffed(m, 0, -1);
                    i++;
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m != target && !m.untouchable)
                {
                    p.minionGetBuffed(m, 0, -1);
                    i++;
                }
            }
            p.minionGetBuffed(target, 0, i);
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
