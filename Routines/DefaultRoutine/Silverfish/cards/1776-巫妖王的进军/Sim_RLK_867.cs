using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Vrykul Necrolyte
	//维库通灵师
	//[x]<b>Battlecry:</b> Give a friendlyminion "<b>Deathrattle:</b> Summon a 2/2 Zombiewith <b>Rush</b>."
	//<b>战吼：</b>使一个友方随从获得“<b>亡语：</b>召唤一个2/2并具有<b>突袭</b>的僵尸。”
	class Sim_RLK_867 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
				target.enchs += "RLK_867e";
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}
