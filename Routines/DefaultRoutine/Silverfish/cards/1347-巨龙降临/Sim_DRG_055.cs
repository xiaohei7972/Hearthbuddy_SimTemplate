namespace HREngine.Bots
{
	class Sim_DRG_055 : SimTemplate //* 藏宝匪贼 Hoard Pillager
	{
		//<b>Battlecry:</b> Equip one of your destroyed weapons.
		//<b>战吼：</b>装备一把你的被摧毁的武器。
		CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_521t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.equipWeapon(w, own.own);
		}
	}
}