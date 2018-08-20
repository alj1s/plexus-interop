/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
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
package com.db.plexus.interop.dsl.gen.meta

import com.db.plexus.interop.dsl.gen.PlexusGenConfig
import java.io.IOException
import com.db.plexus.interop.dsl.gen.util.FileUtils
import java.io.File
import com.db.plexus.interop.dsl.gen.BaseGenTask
import org.eclipse.xtext.resource.XtextResourceSet
import static com.db.plexus.interop.dsl.validation.Issues.*;

class MetaValidatorTask extends BaseGenTask {

    override doGenWithResources(PlexusGenConfig config, XtextResourceSet rs) throws IOException {
        val issues = validator.getValidationIssues(rs)
        if(!issues.empty) {
            val issuesString = issuesToString(issues.sortWith(issuesComparator));
            if(config.isVerbose() || config.getOutFile() === null) {
                println(issuesString)
            }
            if(config.outFile !== null) {
                FileUtils.writeStringToFile(new File(config.outFile), issuesString)
            }
            if(hasErrors(issues)) {
                System.exit(1);
            }
        }
    }

    override validateResources(XtextResourceSet resourceSet) {
        // skip default validation
    }

    override inputFilesGlob(PlexusGenConfig config) {
        "*.interop"
    }
}