using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_236: SimTemplate //* 破冰斧 Ice Breaker
//Destroy any <b>Frozen</b> minion damaged by_this.
//消灭所有受到该武器伤害的被<b>冻结</b>的随从。 
    {
        
        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_236);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }
    }
}