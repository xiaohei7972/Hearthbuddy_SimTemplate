using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：4
	//Sheriff Barrelbrim
	//桶沿警长
	//<b>Battlecry:</b> If you have20 or less Health, openthe Badlands Jail.
	//<b>战吼：</b>如果你的生命值小于或等于20点，开启荒芜之地监狱。
	class Sim_WW_359 : SimTemplate
	{
		CardDB.Card location = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_359t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			Minion hero = own.own ? p.ownHero : p.enemyHero;
			if (hero.Hp <= 20)
			{
				p.callKid(location, own.zonepos, own.own);
			}
		}
		
	}
}
