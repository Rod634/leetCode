namespace leetCode.AddTwoNumbers
{
    public class AddTWoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            var firstNode = new ListNode();
            var num1 = ListToInt(l1);
            var num2 = ListToInt(l2);

            var result = num1 + num2;
            var digits = result.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            var aux = digits.Length - 1;

            firstNode.val = digits[0];

            while (aux > 0)
            {
                //Criar o último node com o next null
                //Atribuir o valor do último digito ao val
                var nextNode = new ListNode(digits[aux]);

                //verificar se ainda existem digitos
                //caso tenha criar um novo node que recebe lastNode como next
                //atribuir o valor do digito ao val
                var node = nextNode.next;

                aux--;
            }

            return firstNode;
        }

        //public bool hasNext(ListNode l) {  return l.next != null; }

        public int ListToInt(ListNode l)
        {
            ListNode list = l;
            int multiplerBase = 1;
            int result = 0;

            while (list != null)
            {
                result = result + list.val * multiplerBase;
                list = list.next;
                multiplerBase = multiplerBase * 10;
            }

            return result;
        }
    }
}