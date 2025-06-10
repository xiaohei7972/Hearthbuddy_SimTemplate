using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：1 攻击力：1 生命值：1
	//Jade Display
	//青玉展品
	//[x]<b>Deathrattle:</b> Your JadeDisplays have +1/+1 thisgame. Shuffle 2 of theminto your deck.
	//<b>亡语：</b>在本局对战中，你的青玉展品拥有+1/+1。将2张青玉展品洗入你的牌库。
	class Sim_TOY_803 : SimTemplate
	{
        private static int jadeDisplayBuffAttack = 0;
        private static int jadeDisplayBuffHealth = 0;

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 增加青玉展品的全局增益 +1/+1
            jadeDisplayBuffAttack += 1;
            jadeDisplayBuffHealth += 1;

            // 将2张青玉展品洗入牌库
            for (int i = 0; i < 2; i++)
            {
                p.AddToDeck(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_803));
            }
        }
    }
}
