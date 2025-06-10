using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_013t : SimTemplate //* 法力过剩 Excess Mana
	{
		//Draw a card. <i>(You can only have 10 Mana in your tray.)</i>
		//抽一张牌。<i>（你最多可以拥有十个法力水晶。）</i>
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}