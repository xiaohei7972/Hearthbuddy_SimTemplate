using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_026 : SimTemplate //* 克雷什，群龟之王 Kresh, Lord of Turtling
	{
        //<b>Frenzy:</b> Gain 8 Armor. <b>Deathrattle:</b> Equip a 2/5 Turtle Spike.
        //<b>暴怒：</b>获得8点护甲值。<b>亡语：</b>装备一把2/5的龟甲尖刺。
        public override void onEnrageStart(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownHero.armor += 8;
            }
            else
            {
                p.enemyHero.armor += 8;
            }
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_026t), m.own);
        }

    }
}
