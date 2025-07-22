using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_071: SimTemplate //* 光之悲恸 Light's Sorrow
//After a friendly minion loses <b>Divine Shield</b>, gain +1 Attack.
//在一个友方随从失去<b>圣盾</b>后，获得+1攻击力。 
    {
        
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_071);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
    }
}