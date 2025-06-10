using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_829: SimTemplate //* 黑锋骑士乌瑟尔 Uther of the Ebon Blade
//<b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
//<b>战吼：</b>装备一把5/3并具有<b>吸血</b>的武器。 
    {
        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_829t); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_829p, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            p.equipWeapon(w, ownplay);
        }
    }
}