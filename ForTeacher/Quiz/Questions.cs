using System;
using System.Collections.Generic;
using System.Linq;

namespace quiz
{
    class Questions
    {
        static void Main(string[] args)
        {
        }

        #region 1. Что включает в себя IEnumerator?
        void QuestionEnumerator()
        {
            IEnumerable<int> numbers = new[] { 1, 2, 3 };
        }

        #region 2. Как профильтровать коллекцию?
        void AnswerFilter()
        {
            var numbers = new[] { 1, 2, 3 };
            var filteredNumbers = numbers.Where(x => x % 2 == 0);
        }

        #region 3. Что делает SelectMany?
        void AnswerMany()
        {
            var numbers = new[] { 1, 2, 3 };
            var xs = numbers.SelectMany(n => new[] { n, n * 2, n * 3 });
            numbers.SelectMany(n => new[] { 'a', 'b', 'c' });
        }

        #region 4. В чем проблема кода?
        void QuestionSelect()
        {
            UserClient client = new UserClient();
            IEnumerable<User> users = client.SelectUsers();

            int count = users.Count();
            Dictionary<string, User> xs =
                users.ToDictionary(u => u.Email);
        }

        #region 5. Как работает ToArray?
        void QuesitonArray()
        {
            IEnumerable<int> numbers = new[] { 1, 2, 3 };
            int[] array = numbers.ToArray();
        }

        #region 6. Что делает Distinct?
        void QuestionDistinct()
        {
            var numbers = Enumerable.Range(0, 10000)
                .Concat(Enumerable.Range(0, 10000))
                .ToList();

            var uniqueNumbers = new HashSet<int>(numbers).ToList();
            var distinctNumbers = numbers.Distinct().ToList();
        }
        #endregion
        #endregion
        #endregion
        #endregion
        #endregion
        #endregion
    }

    class User
    {
        public string Email;
    }

    class UserClient
    {
        public IEnumerable<User> SelectUsers()
        {
            throw new NotImplementedException();
        }
    }
}
