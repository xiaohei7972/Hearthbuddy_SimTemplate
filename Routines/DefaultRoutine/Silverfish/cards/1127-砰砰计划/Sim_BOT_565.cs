using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_565 : SimTemplate //* 荒疫爬行者 Blightnozzle Crawler
//<b>Deathrattle:</b> Summon a 1/1 Ooze with <b>Poisonous</b> and <b>Rush</b>.
//<b>亡语：</b>召唤一个1/1并具有<b>剧毒</b>和<b>突袭</b>的软泥怪。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_565t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}