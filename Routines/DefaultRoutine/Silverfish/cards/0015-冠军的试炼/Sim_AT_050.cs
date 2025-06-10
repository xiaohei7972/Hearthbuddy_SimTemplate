using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_050 : SimTemplate //* 灌魔之锤 Charged Hammer
//<b>Deathrattle:</b> Your Hero Power becomes 'Deal 2 damage.'
//<b>亡语：</b>你的英雄技能改为“造成2点伤害”。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_050);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.AT_050t, m.own); 
        }
    }
}