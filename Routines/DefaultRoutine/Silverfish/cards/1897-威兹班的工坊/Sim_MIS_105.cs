using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Bargain Bin
	//折价篓
	//<b>Secret:</b> After your opponent plays a minion, spell, or weapon, draw a card of the other 2 types.
	//<b>奥秘：</b>在你的对手使用一张随从，法术或武器牌后，你抽取其余两种类型的牌各一张。
	class Sim_MIS_105 : SimTemplate
	{

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            // 当奥秘触发时调用该方法
            if (!ownplay) return; // 只在己方奥秘触发时执行

            CardDB.cardtype playedCardType = (CardDB.cardtype)number;

            // 根据对手所打出的牌类型，抽取其他两种类型的牌
            if (playedCardType == CardDB.cardtype.MOB)
            {
                // 对手打出随从牌，抽取法术和武器牌各一张
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            }
            else if (playedCardType == CardDB.cardtype.SPELL)
            {
                // 对手打出法术牌，抽取随从和武器牌各一张
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            }
            else if (playedCardType == CardDB.cardtype.WEAPON)
            {
                // 对手打出武器牌，抽取随从和法术牌各一张
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            }
        }
    }
}
