using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMC_94 : SimTemplate //* 萨弗拉斯 Sulfuras
//<b>Deathrattle:</b> Your Hero Power becomes 'Deal 8_damage to a random enemy'.
//<b>亡语：</b>你的英雄技能变为“随机对一个敌人造成8点伤害”。 
	{
		
		
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRMC_94);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.BRM_027p, m.own); 
        }
    }
}