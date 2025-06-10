using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_206 : SimTemplate //* 光铸凯瑞尔 lightforgedcariel
	{
		//<b>战吼：</b>对所有敌人造成2点伤害。装备一块2/5的无法撼动之物。
		CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_146);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            p.setNewHeroPower(CardDB.cardIDEnum.AV_206p, ownplay);
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
           
            p.equipWeapon(w, ownplay);
            p.allMinionOfASideGetDamage(!ownplay, 2);
            
		}

	}
}
