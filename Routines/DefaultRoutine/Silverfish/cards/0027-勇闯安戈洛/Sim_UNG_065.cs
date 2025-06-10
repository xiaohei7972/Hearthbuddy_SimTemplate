using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_065 : SimTemplate //* “尸魔花”瑟拉金 Sherazin, Corpse Flower
//<b>Deathrattle:</b> Go <b>Dormant</b>. Play 4 cards in a turn to revive this minion.
//<b>亡语：</b>进入<b>休眠</b>状态。在一回合中使用四张牌可唤醒该随从。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_065t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}