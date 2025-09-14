using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：2
	//Toxfin
	//毒鳍鱼人
	//<b>Battlecry:</b> Give a friendly Murloc <b>Poisonous</b>.
	//<b>战吼：</b>使一个友方鱼人获得<b>剧毒</b>。
	class Sim_BG_DAL_077 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            if (target != null && own.own)
            {
                target.poisonous = true;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 14),
            };
        }
		
	}
}
