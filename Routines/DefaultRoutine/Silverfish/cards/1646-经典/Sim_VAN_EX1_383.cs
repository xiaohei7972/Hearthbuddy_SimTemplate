using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_383 : SimTemplate //* 提里奥·弗丁 Tirion Fordring
	{
		//<b><b>Divine Shield</b>,</b> <b>Taunt</b> <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
		//<b>圣盾</b>，<b>嘲讽</b>，<b>亡语：</b>装备一把5/3的灰烬使者。
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_383t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.equipWeapon(card,m.own);
        }

	}
}