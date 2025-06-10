using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：7
	//Trial by Fire
	//火焰试炼
	//[x]Summon five 1/1Val'kyr with <b>Rush</b>.When one dies, givethe others +1/+1.
	//召唤五个1/1并具有<b>突袭</b>的瓦格里。当一个死亡时，使其他的获得+1/+1。
	class Sim_TTN_470 : SimTemplate
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_470t);// 瓦格里勇士

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count; // 位置
            p.callKid(kid, pos, ownplay, false); // 召唤瓦格里勇士
			p.callKid(kid, pos, ownplay, false); // 召唤瓦格里勇士
			p.callKid(kid, pos, ownplay, false); // 召唤瓦格里勇士
			p.callKid(kid, pos, ownplay, false); // 召唤瓦格里勇士
			p.callKid(kid, pos, ownplay, false); // 召唤瓦格里勇士	
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 5),// 需要5个空位
            };
        }
		
	}
}
