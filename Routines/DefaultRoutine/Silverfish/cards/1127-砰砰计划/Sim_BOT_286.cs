using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_286 : SimTemplate //* 死金匕首 Necrium Blade
//<b>Deathrattle:</b> Trigger the <b>Deathrattle</b> of a random friendly minion.
//<b>亡语：</b>随机触发一个友方随从的<b>亡语</b>。
    {
        
		
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_286);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m != null) p.doDeathrattles(new List<Minion>() { m });            
        }
    }
}
