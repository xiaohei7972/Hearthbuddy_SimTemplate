using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：0
	//Runes of the Unholy
	//邪恶符文
	//Summon two 3/3 Undead with <b>Taunt</b>and <b>Reborn</b>.
	//召唤两个3/3并具有<b>嘲讽</b>和<b>复生</b>的亡灵。
	class Sim_TTN_737t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 2; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_737t2), p.ownMinions.Count, true, false); // 召唤2个3/3并具有嘲讽和复生的亡灵
            }
            p.drawACard(CardDB.cardIDEnum.None, true, true);
        }
    }
}
