using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 巫妖王 费用：3 攻击力：1 耐久度：0
	//Staff of the Endbringer
	//末日使者之杖
	//<b>Deathrattle:</b> Destroy all minions.
	//<b>亡语：</b>消灭所有随从。
	class Sim_TLC_EVENT_402 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_EVENT_402);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDestroyed();
        }
	}
}
