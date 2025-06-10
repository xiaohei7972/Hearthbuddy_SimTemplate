using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Parachute
	//降落伞
	//<b>Casts When Drawn</b>Summon a 1/1 Pirate with <b>Charge</b>.
	//<b>抽到时施放</b>召唤一个1/1并具有<b>冲锋</b>的海盗。
	class Sim_VAC_933t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_933); // 卡牌
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice) // 施放
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count; // 位置
            p.callKid(kid, pos, ownplay, false); // 召唤
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
            };
        }
	}
}
