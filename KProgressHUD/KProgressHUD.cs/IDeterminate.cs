/*
 *    Copyright 2015 Kaopiz Software Co., Ltd.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 */

namespace KProgressHUDLib
{
    /**
     * If a view , this interface passed to the HUD as a custom view, its progress
     * can be updated by calling SetMax() and SetProgress() on the HUD.
     * This interface only provides convenience, how progress work depends on the view implementation.
     */

    public interface IDeterminate
    {
        void SetMax(int max);

        void SetProgress(int progress);
    }
}