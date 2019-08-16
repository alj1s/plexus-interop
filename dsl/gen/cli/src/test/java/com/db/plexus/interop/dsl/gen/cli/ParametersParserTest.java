/**
 * Copyright 2017-2019 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.db.plexus.interop.dsl.gen.cli;

import com.beust.jcommander.ParameterException;
import com.db.plexus.interop.dsl.gen.PlexusGenConfig;
import org.junit.Assert;
import org.junit.Test;

public class ParametersParserTest {

    private ParametersParser sut = new ParametersParser();

    @Test
    public void testParseParameters() {
        final PlexusGenConfig parameters = sut.parse(new String[]{"--type=ts", "-i", "*", "--baseDir", "."});
        Assert.assertEquals("ts", parameters.getType());
        Assert.assertEquals("*", parameters.getInput());
        Assert.assertEquals(".", parameters.getBaseDir());
    }

    @Test(expected = ParameterException.class)
    public void testRequiredParameters() {
        sut.parse(new String[]{"-i", "*", "--baseDir", "."});
    }

}
